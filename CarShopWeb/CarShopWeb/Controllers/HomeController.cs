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

namespace CarShopWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICarRepository _carRepository;
        public HomeController(ILogger<HomeController> logger, ICarRepository carRepository)
        {
            _carRepository = carRepository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Car> cars = _carRepository.GetAllCars().ToList();
            cars.Count();
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
    }
}
