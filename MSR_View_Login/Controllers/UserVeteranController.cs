using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSR_Web_App.Models;
using Microsoft.AspNet.Identity;

namespace MSR_Web_App.Controllers
{
    [Authorize]
    public class UserVeteranController : Controller
    {
        private Msr_Database_Release_TwoEntities1 db = new Msr_Database_Release_TwoEntities1();
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