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
    public class UserVeteranController : Controller
    {
        private MSRContext db = new MSRContext();
        // GET: Veteran
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Manage()
        {
            return View();
        }
    }
}