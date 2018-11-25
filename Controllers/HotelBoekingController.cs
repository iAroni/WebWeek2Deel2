using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebWeek2Deel2.Models;

namespace WebWeek2Deel2.Controllers
{
    public class HotelBoekingController : Controller
    {
        [HttpGet]
        public IActionResult Boeken()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Boeken(Hotel h)
        {
            return View("Geboekt", h);  
        } 

        [HttpPost]
        public IActionResult Edit(Hotel h)
        {
            return View("Edit", h);
        }

        [HttpPost]
        public IActionResult Gewijzigd(Hotel h)
        {
            return View("Gewijzigd", h);
        }
    }
}