using CarShop.BL.Interfaces;
using CarShopWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using СarShop.DataLayer.Entities;
using CarShop.PresentationLayer;
using CarShop.PresentationLayer.Servicies;

namespace CarShopWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarService _service;

        public HomeController(ILogger<HomeController> logger, ICarService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            AllCarsModel AllCars = new AllCarsModel();

            AllCars.cars = _service.GetCarsList();

            return View("HomePage", AllCars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
