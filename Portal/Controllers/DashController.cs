using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using Portal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portal.Services;

namespace Portal.Controllers
{
    public class DashController : Controller
    {
        private readonly DataContext _context;
        private readonly log4net.ILog _log4net;
        private readonly IAddPharmacyService _addPharmacyService;
        private readonly IAddScheduleService _addScheduleService;
        public DashController(DataContext context,IAddScheduleService addScheduleService,IAddPharmacyService addPharmacyService)
        {
            _addPharmacyService = addPharmacyService;
            _addScheduleService = addScheduleService;
            _log4net = log4net.LogManager.GetLogger(typeof(DashController));
            _context = context;
        }
        public IActionResult Index()
        {
            if (GlobalData.TokenExist)
            {
                ViewBag.isLoggedIn = "1";
                ViewBag.user = GlobalData.CurrentUser;
                ViewBag.Message = "";
                return View();
            }
            GlobalData.Token = "";
            GlobalData.TokenExist = false;
            return View("Unauthorized");
        }
        public IActionResult SavePharmacy()
        {
            _log4net.Info("Supply List Saved to DB");
            if (GlobalData.TokenExist)
            {
                ViewBag.isLoggedIn = "1";
                ViewBag.user = GlobalData.CurrentUser;
                //AddPharmacyRepository addPharmacyRepository = new AddPharmacyRepository();
                //addPharmacyRepository.AddToDb(GlobalData.Pharmacies, _context);
                _addPharmacyService.AddToDb(GlobalData.Pharmacies, _context);
                ViewBag.Message = "Pharmacy Medicine Supply details stored in Dashboard.";
                return View("Saved");
            }
            GlobalData.Token = "";
            GlobalData.TokenExist = false;
            return View("Unauthorized");
        }
        public IActionResult SaveSchedule()
        {
            _log4net.Info("Schedule List Saved to DB");
            if (GlobalData.TokenExist)
            {
                ViewBag.isLoggedIn = "1";
                ViewBag.user = GlobalData.CurrentUser;
                //AddScheduleRepository addScheduleRepository = new AddScheduleRepository();
                //addScheduleRepository.AddToDb(GlobalData.Schedules, _context);
                _addScheduleService.AddToDb(GlobalData.Schedules, _context);
                ViewBag.Message = "Representative Schedule details stored in Dashboard.";
                return View("Saved");
            }
            GlobalData.Token = "";
            GlobalData.TokenExist = false;
            return View("Unauthorized");
        }
        public IActionResult ShowSchedule()
        {
            _log4net.Info("Schedule List retrieved from DB");
            if (GlobalData.TokenExist)
            {
                ViewBag.isLoggedIn = "1";
                ViewBag.user = GlobalData.CurrentUser;
                //AddScheduleRepository addScheduleRepository = new AddScheduleRepository();
                //return View(addScheduleRepository.GetFromDb(_context));
                return View(_addScheduleService.GetFromDb(_context));
            }
            GlobalData.Token = "";
            GlobalData.TokenExist = false;
            return View("Unauthorized");
        }
        public IActionResult ShowPharmacy()
        {
            _log4net.Info("Supply List retrieved from DB");
            if (GlobalData.TokenExist)
            {
                ViewBag.isLoggedIn = "1";
                ViewBag.user = GlobalData.CurrentUser;
                //AddPharmacyRepository addPharmacyRepository = new AddPharmacyRepository();
                //return View(addPharmacyRepository.GetFromDb(_context));
                return View(_addPharmacyService.GetFromDb(_context));
            }
            GlobalData.Token = "";
            GlobalData.TokenExist = false;
            return View("Unauthorized");
        }

    }
}
