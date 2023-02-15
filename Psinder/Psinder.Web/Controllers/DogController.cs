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



        // GET: DogController/Details/5
        //public async Task <ActionResult> Details()
        //{
        //    var dog = await _dogServices.GetAsync();


        //}

        // GET: DogController/Create
        public async Task<ActionResult> Create()
        {
            ViewData["DogBreeds"] = GetDogBreeds();
            return View();
        }

        // POST: DogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Create(DogCreateModelView dogCreate)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogInformation($"{dogCreate.Name} Nie powiodło się tworzenie zwierzaka", ModelState);
                return View(dogCreate);
            }
            var dog = _mapper.Map<Dog>(dogCreate);

            try
            {
                await _dogServices.AddAsync(User,dog);
                return RedirectToAction("Details","User");
            }
            catch
            {
                return View();
            }
        }

        // GET: DogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private IEnumerable<SelectListItem> GetDogBreeds()
        {
            return _context.DogBreeds.ToList().OrderBy(n => n.Name).Select(p =>
            {
                return new SelectListItem($"{p.Name}", p.Id.ToString());
            });



        }
    }
}
