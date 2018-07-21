using ModelBindingCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBindingCalculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string param)
        {
            Calculator calc = new Models.Calculator();
            ViewBag.Param = param;
            return View(calc);
        }
        // POST : Home
        [HttpPost]
        public ActionResult Index(Calculator calc)
        {
            if (ModelState.IsValid)
            {
                calc.Calculate();
            }
            return View(calc);
        }
    }
}