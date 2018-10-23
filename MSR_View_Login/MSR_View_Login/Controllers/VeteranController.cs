using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplifiedLogin.Controllers
{
    public class VeteranController : Controller
    {
        // GET: Veteran
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Manage()
        {
            return View();
        }
        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}