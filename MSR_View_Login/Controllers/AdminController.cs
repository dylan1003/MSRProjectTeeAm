using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSR_mvc.Models;
using Microsoft.AspNet.Identity;

namespace SimplifiedLogin.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Create Veteran
        public ActionResult CreateVeteran()
        {
            if (User.Identity.GetUserName() == "admin" || User.Identity.GetUserName() == "Admin")
            {
                return View();
            }
            return View();
        }

        // Post: Create Veteran
        [HttpPost]
        public ActionResult CreateVeteran(Veteran newVeteran)
        {
            return View();
        }
    }
}