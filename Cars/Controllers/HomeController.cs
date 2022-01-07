﻿using Cars.Models;
using Cars.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarsContext _context;
        public HomeController(ILogger<HomeController> logger, CarsContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //string info = new WebClient().DownloadString("http://ipinfo.io/" + remoteIpAddress); //replace by remoteIpAddress
            //remotip ipinfo = JsonConvert.DeserializeObject<remotip>(info);

            //ViewBag.city = ipinfo.City;
            //ViewBag.Region = ipinfo.Region;
            //ViewBag.IP = remoteIpAddress;




            //UsersLogs usersLogs = new UsersLogs
            //{
            //    UserIP = remoteIpAddress,
            //    UserRegion = ipinfo.Region,
            //    UserCity = ipinfo.City,
            //    UserID = userId,
            //    CreateDts = DateTime.Now
            //};
            //_context.Add(usersLogs);
            //_context.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            if (culture.Contains("ar"))
            {
                StaticValues.RTL = true;
            }
            else
            {
                StaticValues.RTL = false;
            }
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect("/");
        }
    }
}
