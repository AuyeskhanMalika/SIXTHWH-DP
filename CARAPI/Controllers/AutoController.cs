using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CARAPI.Controllers
{
    public class AutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AutoInfo(string name, int price, int ID = 1)
        {
            ViewData["Name"] = "This is " + name;
            ViewData["Price"] = price;
            ViewData["ID"] = ID;

            return View();
        }
    }
}