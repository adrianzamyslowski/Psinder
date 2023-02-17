using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Psinder.Core.Model;
using Psinder.Repository;
using Psinder.Services.DogServices;
using Psinder.Services.UserServices;
using Psinder.Web.Models.Dog;
using Psinder.Web.Models.User;

namespace Psinder.Web.Controllers
{
    [Authorize]
    public class DogController : Controller
    {
        private readonly IDogServices _dogServices;
        private readonly IUserServices _userServices;
        private readonly IMapper _mapper;
        private readonly ILogger<UserController> _logger;
        private readonly PsinderContext _context;

        public DogController(IDogServices dogServices,
                             IUserServices userServices,
                             IMapper mapper,
                             ILogger<UserController> logger,
                             PsinderContext context)
        {
            _dogServices = dogServices;
            _userServices = userServices;
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }



        //  GET: DogController/Details/
        public async Task<ActionResult> Details(int id)
        {
            //int id = Convert.ToInt32(TempData["ID"]);
            var dog = await _dogServices.GetAsync(id);
            var dogDetails = _mapper.Map<DogDetailsModelView>(dog);
            return View(dogDetails);
        }

        //  GET: DogController/Details/
        public async Task<ActionResult> DetailsAllDogs()
        {
            var allDogs = await _dogServices.GetAllUserDogsAsync(User);
            var dogDetails = _mapper.Map<List<DogDetailsModelView>>(allDogs).OrderBy(n => n.Name).ToList();
            return View(dogDetails);
        }
        // GET: DogController/Create
        public async Task<ActionResult> Create()
        {
            ViewData["DogBreeds"] = GetDogBreeds();
            return View();
        }

        // POST: DogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(DogCreateModelView dogCreate)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogInformation($"{dogCreate.Name} Nie powiodło się tworzenie zwierzaka", ModelState);
                return View(dogCreate);
            }
            var dog = _mapper.Map<Dog>(dogCreate);

            if (dogCreate.DateOfBirth > DateTime.Now)
            {
                ModelState.AddModelError("", "Nie moższ podać daty przyszłej");
                ViewData["DogBreeds"] = GetDogBreeds();
                return View(dogCreate);
            }
            try
            {
                await _dogServices.AddAsync(User, dog);
                _logger.LogInformation($"{dogCreate.Name} Użytkownik utworzony poprawnie");
                // TempData["ID"] = dog.Id;
                return RedirectToAction("Details", new { id = dog.Id });
            }
            catch
            {
                _logger.LogInformation($"{dogCreate.Name} Nie powiodło się  tworzenie użytkowika", ModelState);
                return View(dogCreate);
            }
        }

        // GET: DogController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var dog = await _dogServices.GetAsync(id);
            var dogEdit = _mapper.Map<DogEditModelView>(dog);
            ViewData["DogBreeds"] = GetDogBreeds();
            return View(dogEdit);
        }

        // POST: DogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(DogEditModelView dogEdit)
        {
            var dog = _mapper.Map<Dog>(dogEdit);

            if (!ModelState.IsValid)
            {
                _logger.LogInformation($"{dogEdit.Name} edycja psa nie powiodło się", ModelState);
                return View(dogEdit);
            }

            try
            {
                await _dogServices.UpdateAsync(dog);
                _logger.LogInformation($"{dogEdit.Name} aktualizacja poprawna");
                return RedirectToAction("Details", new { id = dog.Id });
                
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"{dogEdit.Name} edycja danych błędna, {exception.GetType()}", ModelState);
                return View(dogEdit);
            }
        }

        // GET: DogController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var dog = await _dogServices.GetAsync(id);
            var dogDelete = _mapper.Map<DogDeleteModelView>(dog);
            return View(dogDelete);
        }

        // POST: DogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(DogDeleteModelView dogDelete)
        {
            var originalDog = await _dogServices.GetAsync(dogDelete.Id);

            dogDelete = _mapper.Map<DogDeleteModelView>(originalDog);


            if (!ModelState.IsValid)
            {
                _logger.LogInformation($"{dogDelete.Name} usunięcie psa nie powiodło się", ModelState);
                return View(dogDelete);
            }

            try
            {
                await _dogServices.DeleteAsync(dogDelete.Id);
                _logger.LogInformation($"{dogDelete.Name} deleted successful");
                return RedirectToAction(nameof(DetailsAllDogs));
            }
            catch (Exception exception)
            {
                _logger.LogError($"{dogDelete.Name} błąd usunięcia, {exception.GetType()}", ModelState);
                return View(dogDelete);
            }
            return View();
        }

        private IEnumerable<SelectListItem> GetDogBreeds()
        {
            return _context.DogBreeds.ToList().OrderBy(n => n.Name).Select(p =>
            {
                return new SelectListItem($"{p.Name}", p.Name);
            });
        }
    }
}
