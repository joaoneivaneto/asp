using BethenyPieShop2.Models;
using BethenyPieShop2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethenyPieShop2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheweek = _pieRepository.PiesOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
