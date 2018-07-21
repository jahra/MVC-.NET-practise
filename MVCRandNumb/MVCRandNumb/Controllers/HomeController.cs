using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRandNumb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Models.Generator generator = new Models.Generator();
            ViewBag.Numb = generator.getNumber(); 
            return View();
        }
    }
}