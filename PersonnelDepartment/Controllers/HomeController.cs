using PersonnelDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonnelDepartment.Business;

namespace PersonnelDepartment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAbout AboutProvider;
        public HomeController(IAbout AboutProvider)
        {
            this.AboutProvider = AboutProvider;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {            
            return View(new AboutModel { AboutInfo=AboutProvider.GetAboutInfo("Some information") });
        }
    }
}