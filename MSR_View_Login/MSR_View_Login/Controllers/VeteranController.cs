using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimplifiedLogin.Controllers
{
    [Authorize]
    public class VeteranController : Controller
    {
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