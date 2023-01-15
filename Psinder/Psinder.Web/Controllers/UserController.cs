using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Psinder.Core.Model;
using Psinder.Services.UserServices;
using Psinder.Web.Models.User;
using System.Numerics;
using System.Security.Claims;

namespace Psinder.Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;
        private readonly IMapper _mapper;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserServices userServices,
                              IMapper mapper,
                              SignInManager<User> signInManager,
                              ILogger<UserController> logger)
        {
            _userServices = userServices;
            _mapper = mapper;
            _signInManager = signInManager;
            _logger = logger;
        }

        // GET: UserController/Details/5
        public async Task<ActionResult> Details()
        {
            var user = await _userServices.GetAsync(User);
            var userDetails = _mapper.Map<UserDetailsModelView>(user);
            return View(userDetails);
        }

        // GET: UserController/Create
        [AllowAnonymous]
        public async Task<ActionResult> Create()
        {
            await _signInManager.SignOutAsync();
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<ActionResult> Create(UserCreateModelView userCreate)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogInformation($"{userCreate.UserName} Nie powiodło się tworzenie użytkowika", ModelState);
                return View(userCreate);
            }

            var user = _mapper.Map<User>(userCreate);

            try
            {
                await _userServices.CreateAsync(user, userCreate.Password);
                await _signInManager.SignInAsync(user, isPersistent: false);
                _logger.LogInformation($"{user.UserName} Użytkownik utworzony poprawnie");
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                _logger.LogInformation($"{userCreate.UserName} Nie powiodło się  tworzenie użytkowika", ModelState);
                return View(userCreate);
            }
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLogInModelView userLogIn)
        {
            var result = await _signInManager.PasswordSignInAsync(userLogIn.UserName, userLogIn.Password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                _logger.LogInformation($"Pomyślne logowanie użytkownika {userLogIn.UserName}");
                return RedirectToAction(nameof(Details));
            }

            ModelState.AddModelError("", "Nieprawidłowa próba logowania");
            _logger.LogError($"Logowane się niepowidło {userLogIn.UserName}", ModelState);
            return View(userLogIn);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Index), "Home");
        }

        // GET: UserController/Edit
        public async Task<ActionResult> Edit()
        {
            var user = await _userServices.GetAsync(User);
            var userEdit = _mapper.Map<UserEditModelView>(user);
            return View(userEdit);
        }

        // POST: UserController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(UserEditModelView userEdit)
        {

            var originalUser = await _userServices.GetAsync(User);
            userEdit.UserName = originalUser.UserName;

            if (!ModelState.IsValid)
            {
                _logger.LogInformation($"{userEdit.UserName} nie powiodło się edytowanie informacji o koncie", ModelState);
                return View(userEdit);
            }

            var user = _mapper.Map<User>(userEdit);
            user.Id = (await _userServices.GetAsync(User)).Id;

            try
            {
                await _userServices.UpdateAsync(user);
                _logger.LogInformation($"{userEdit.UserName} aktualizacja poprawna");
                return RedirectToAction(nameof(Details));
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"{userEdit.UserName} edycja danych błędna, {exception.GetType()}", ModelState);
                return View(userEdit);
            }
        }

        // GET: UserController/EditPassword
        public async Task<ActionResult> EditPassword()
        {
            var user = await _userServices.GetAsync(User);
            var passwordChange = _mapper.Map<PasswordChangeModelView>(user);
            return View(passwordChange);
        }

        // POST: UserController/EditPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditPassword(PasswordChangeModelView passwordChange)
        {
            var originalUser = await _userServices.GetAsync(User);
            passwordChange.UserName = originalUser.UserName;


            if (!ModelState.IsValid)
            {
                _logger.LogInformation($"{passwordChange.UserName} zmiana hasła nie powiodła się", ModelState);
                return View(passwordChange);
            }

            try
            {
                await _userServices.ChangePasswordAsync(User, passwordChange.CurrentPassword, passwordChange.NewPassword);
                _logger.LogInformation($"{passwordChange.UserName} zmiana hasła powiodła się");
                return RedirectToAction(nameof(Edit));
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"{passwordChange.UserName} zmiana hasła nie powiodła sięa, {exception.GetType()}", ModelState);
                return View(passwordChange);
            }
        }

        // GET: UserController/Delete
        public async Task<ActionResult> Delete()
        {
            var user = await _userServices.GetAsync(User);
            var userForDelete = _mapper.Map<UserDeleteModelView>(user);
            return View(userForDelete);
        }

        // POST: UserController/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(UserDeleteModelView userDelete)
        {
            var originalUser = await _userServices.GetAsync(User);
            var passwordConfirm = userDelete.PasswordConfirm;

            userDelete = _mapper.Map<UserDeleteModelView>(originalUser);

            if (!ModelState.IsValid)
            {
                _logger.LogInformation($"{originalUser.UserName} usunięcie użytkownia nie powiodło się", ModelState);
                return View(userDelete);
            }

            try
            {
                await _userServices.DeleteAsync(User, passwordConfirm);
                _logger.LogInformation($"{userDelete.UserName} deleted successful");
                return RedirectToAction(nameof(Logout));
            }
            catch (Exception exception)
            {
                _logger.LogError($"{userDelete.UserName} błędna zmiana hasła {exception.GetType()}", ModelState);
                return View(userDelete);
            }
        }
    }
}
