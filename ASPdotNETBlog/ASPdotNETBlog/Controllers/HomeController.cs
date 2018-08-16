using ASPdotNETBlog.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPdotNETBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //*******************************
            //Create roles and set admin acc
            //*******************************
            //RoleManager<IdentityRole> RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new IdentityDbContext()));
            //RoleManager.Create(new IdentityRole("admin"));
            //UserManager<ApplicationUser> UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            //ApplicationUser user = UserManager.FindByEmail("admin@example.com");
            //UserManager.AddToRole(user.Id, "admin");
            //*******************************
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
    }
}