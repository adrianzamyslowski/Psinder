using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Psinder.Core.Model;
using Psinder.Services.UserServices;
using Psinder.Web.Models;

namespace Psinder.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;
        private readonly IMapper _mapper;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserServices userServices, IMapper mapper, SignInManager<User> signInManager, ILogger<UserController> logger)
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
        public async Task<ActionResult> Create()
        {
            await _signInManager.SignOutAsync();
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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




















        //// GET: UserController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: UserController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: UserController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
