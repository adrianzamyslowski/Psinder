using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Psinder.Services.ParkServices;
using Psinder.Web.Models.Park;

namespace Psinder.Web.Controllers
{
    [Authorize]
    public class ParkController : Controller
    {
        private readonly IParkServices _parkServices;
        private readonly IMapper _mapper;
        private readonly ILogger<ParkController> _logger;

        public ParkController(IParkServices parkServices, IMapper mapper, ILogger<ParkController> logger)
        {
            _parkServices = parkServices;
            _mapper = mapper;
            _logger = logger;
        }


        // GET: ParkController/Details/5
        public async Task<ActionResult> Details()
        {
            var park = await _parkServices.GetAllAsync();
            var parkDetails = _mapper.Map<List<ParkDetailsModelView>>(park).OrderBy(n=>n.NamePark).ToList();

            return View(parkDetails);
        }

        //// GET: ParkController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ParkController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
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

        //// GET: ParkController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ParkController/Edit/5
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

        //// GET: ParkController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ParkController/Delete/5
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
