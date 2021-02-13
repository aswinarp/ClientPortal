using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Portal.Models;
using System;
using System.Diagnostics;
using System.Net.Http;
using Microsoft.AspNetCore.Session;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly log4net.ILog _log4net;
        public HomeController(IConfiguration config)
        {
            _config = config;
            _log4net = log4net.LogManager.GetLogger(typeof(HomeController));
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {   
            if(GlobalData.TokenExist)
                ViewBag.isLoggedIn = "1";
            return View();
        }

        [HttpPost]
        public IActionResult Login(Helper user)
        {
            try { 
            
            _log4net.Info("Trying to Login");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_config["URL:Authorization"]);// Add URL of Authentication MicroService Here
                var responseTask = client.GetAsync("Login?username=" + user.UserName + "&pass=" + user.Password);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    _log4net.Info("Login Successful");
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();           
                    GlobalData.Token = readTask.Result;
                    GlobalData.TokenExist = true;
                    GlobalData.CurrentUser = user.UserName;
                    ViewBag.isLoggedIn = "1";
                    ViewBag.user = GlobalData.CurrentUser;
                    return View("LoggedIn");
                }
            }
            _log4net.Info("Login Failed");
            ViewBag.Message = "Incorrect Username/Password";
            return View();
            }
            catch (Exception) { return View("Unavailable"); }
        }

        public IActionResult LoggedIn()
        {
            if (GlobalData.TokenExist)
            {
                ViewBag.isLoggedIn = "1";
                ViewBag.user = GlobalData.CurrentUser;
                return View();
            }            
            else return View("Unauthorized");
        }

        public IActionResult Logout()
        {
            _log4net.Info("Logged out");
            GlobalData.Token = "";
            GlobalData.TokenExist = false;            
            return View("Index");
        }
    }
}
