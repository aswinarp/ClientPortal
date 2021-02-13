using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Portal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Portal.Repository;

namespace Portal.Controllers
{
    public class PharmacyController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;
        private readonly log4net.ILog _log4net;
        public PharmacyController(IConfiguration config, DataContext context)
        {
            _log4net = log4net.LogManager.GetLogger(typeof(PharmacyController));
            _context = context;
            _config = config;
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (!GlobalData.TokenExist)
                return View("Unauthorized");
            try{
            using (var client = new HttpClient())
            {
                _log4net.Info("Called Medicine Service");
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalData.Token);  //Currently authorization is not stated as requirement for MedicineStock
                client.BaseAddress = new Uri(_config["URL:MedicineStock"]);
                var responseTask = client.GetAsync("GetMedicine");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    _log4net.Info("Got Reply From Medicine Service");
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    if (GlobalData.TokenExist)
                    {
                        ViewBag.isLoggedIn = "1";
                        ViewBag.user = GlobalData.CurrentUser;
                    }
                    List<Medicine> medicines = JsonConvert.DeserializeObject<List<Medicine>>(readTask.Result);
                    List<string> tempList = new List<string>();
                    List<MedicineQuantity> Quantities = new List<MedicineQuantity>();
                    foreach (Medicine item in medicines)
                    {
                        tempList.Add(item.Name);
                        Quantities.Add(new MedicineQuantity { Quantity = 0 });
                    }
                    GlobalData.MedNames = string.Join(',', tempList.ToArray()); // gaviscon,dolo-650,hhhfdhfhdsh,dasasd
                    ViewBag.MedicineNames = GlobalData.MedNames;
                    return View(Quantities);
                }                
            }
            GlobalData.Token = "";
            GlobalData.TokenExist = false;
            ViewBag.Message = "Token Expired. Please Login Again";
            return View("Unauthorized");
            }catch (Exception) { return View("Unavailable"); }
        }
        [HttpPost]
        public IActionResult Index(List<MedicineQuantity> quantities) //{145,1255,1125,1125,45545,1212 }
        {
            List<string> tempList = new List<string>();
            foreach (var item in quantities)
                tempList.Add(item.Quantity.ToString());
            string qtyString = string.Join(',', tempList.ToArray());
                try{
                using (var client = new HttpClient())
                {
                _log4net.Info("Called Pharmacy service");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalData.Token);
                client.BaseAddress = new Uri(_config["URL:Pharmacy"]);
                var responseTask = client.GetAsync("Supply?qtyString=" + qtyString);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    _log4net.Info("Got Supply List");
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    if (GlobalData.TokenExist)
                    {
                        ViewBag.isLoggedIn = "1";
                        ViewBag.user = GlobalData.CurrentUser;
                    }
                    GlobalData.Pharmacies = JsonConvert.DeserializeObject<List<Pharmacy>>(readTask.Result);
                    return View("SupplyList",GlobalData.Pharmacies);
                }
                else if ((int)result.StatusCode == 405)
                {
                    if (GlobalData.TokenExist)
                    {
                        _log4net.Info("Incorrect Input to Pharmacy");
                        ViewBag.Message = "Please make a minimum request of 3 for atleast 1 Medicine ";
                        ViewBag.isLoggedIn = "1";
                        ViewBag.user = GlobalData.CurrentUser;
                        ViewBag.MedicineNames = GlobalData.MedNames;
                        return View();
                    }
                    GlobalData.Token = "";
                    GlobalData.TokenExist = false;
                    return View("Unauthorized");
                }
                else if ((int)result.StatusCode == 400)
                {
                    if (GlobalData.TokenExist)
                    {
                        _log4net.Info("Incorrect Input to Pharmacy");
                        ViewBag.Message = "Medicine quantity cannot be negative";
                        ViewBag.isLoggedIn = "1";
                        ViewBag.user = GlobalData.CurrentUser;
                        ViewBag.MedicineNames = GlobalData.MedNames;
                        return View();
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