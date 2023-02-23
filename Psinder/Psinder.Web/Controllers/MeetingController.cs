using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Psinder.Services.MeetingServices;
using Psinder.Services.ParkServices;
using Psinder.Services.UserServices;
using Psinder.Web.Models.Meeting;
using Psinder.Web.Models.Park;

namespace Psinder.Web.Controllers
{
    public class MeetingController : Controller

    {
        private readonly IMeetingServices _meetingServices;
        private readonly IUserServices _userServices;
        private readonly ILogger<MeetingController> _logger;
        private readonly IMapper _mapper;
        private readonly IParkServices _parkServices;

        public MeetingController(IMeetingServices meetingServices,
                                 IUserServices userServices,
                                 ILogger<MeetingController> logger,
                                 IMapper mapper,
                                 IParkServices parkServices)
        {
            _meetingServices = meetingServices;
            _userServices = userServices;
            _logger = logger;
            _mapper = mapper;
            _parkServices = parkServices;
        }

        // GET: MeetingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MeetingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MeetingController/Create
        public async Task<ActionResult> Create(int id)
        {
            var park = await _parkServices.GetAsync(id);
            var parkname = park.NamePark;
            TempData["id"] = id;
            TempData["name"] = parkname;
            return View();
        }

        // POST: MeetingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MeetingCreateModelView meetingCreateModelView)
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

        // GET: MeetingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MeetingController/Edit/5
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

        // GET: MeetingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MeetingController/Delete/5
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
    }
}
