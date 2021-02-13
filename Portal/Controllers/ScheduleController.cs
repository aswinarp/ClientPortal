using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Portal.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Portal.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IConfiguration _config;
        private readonly log4net.ILog _log4net;
        public ScheduleController(IConfiguration config)
        {
            _log4net = log4net.LogManager.GetLogger(typeof(ScheduleController));
            _config = config;
        }
        public ActionResult Index()
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
        [HttpPost]
        public IActionResult Schedule(Helper date)
        {
            //var dateString = date.StartDate.Date.ToString("MM/dd/yyyy", new CultureInfo("en-US"));
            var dateString = date.StartDate.Date.ToString();
            try
            { 
            using (var client = new HttpClient())
            {
                _log4net.Info("Schedule Service Called");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalData.Token);
                client.BaseAddress = new Uri(_config["URL:Schedule"]);
                var responseTask = client.GetAsync("Create?datestr=" + dateString);//date.StartDate.ToString());
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    if (GlobalData.TokenExist)
                    {
                        ViewBag.isLoggedIn = "1";
                        ViewBag.user = GlobalData.CurrentUser;
                    }
                    GlobalData.Schedules = JsonConvert.DeserializeObject<List<Schedule>>(readTask.Result);
                    return View(GlobalData.Schedules);
                }
                else if((int)result.StatusCode == 405 )
                {
                    _log4net.Info("Incorrect Input to Schedule Service");
                    if (GlobalData.TokenExist)
                    {
                        ViewBag.Message = "Please Enter a date after " + DateTime.Today.ToShortDateString();
                        ViewBag.isLoggedIn = "1";
                        ViewBag.user = GlobalData.CurrentUser;
                        return View("Index");
                    }
                    GlobalData.Token = "";
                    GlobalData.TokenExist = false;
                    return View("Unauthorized");
                }
                    else if ((int)result.StatusCode == 500)
                    {
                        if (GlobalData.TokenExist)
                        {
                            _log4net.Info("Service Not Working");
                            ViewBag.isLoggedIn = "1";
                            ViewBag.user = GlobalData.CurrentUser;
                            return View("Unavailable");
                        }
                        GlobalData.Token = "";
                        GlobalData.TokenExist = false;
                        return View("Unavailable");
                    }
                }
            GlobalData.Token = "";
            GlobalData.TokenExist = false;
            ViewBag.Message = "Token Expired. Please Login Again";
            return View("Unauthorized");
            }catch (Exception) { return View("Unavailable"); }
        }
    }
}

