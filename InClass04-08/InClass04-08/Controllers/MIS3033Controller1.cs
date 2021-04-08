using InClass04_08.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InClass04_08.Controllers
{
    public class MIS3033Controller1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentOfTheYear()
        {
            Student soty = new Student()
            {
                FirstName = "Eric",
                LastName = "Sutherland"
            };
            return View(soty);
        }
    }
}
