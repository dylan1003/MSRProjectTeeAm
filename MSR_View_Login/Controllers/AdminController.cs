using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MSR_Web_App.Models;

namespace MSR_Web_App.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private Msr_Database_Release_TwoEntities db = new Msr_Database_Release_TwoEntities();
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
        [ValidateAntiForgeryToken]
        public ActionResult CreateVeteran([Bind(Include = "Id,FirstName,MiddleName,Surname,DOB,BirthPlace,Death,MaritalStatus,EnlistedDate,EmbarkmentAge,RegimentNumber,Battalion,Religion,Address,State,Country,ShortBio,Fate,Status,ProfilePicture,Fk_User_Id,Fk_Veteran_Queue_Id,PreWarOccupation,NextOfKin")] Veteran veteran)
        {
            if (ModelState.IsValid)
            {
                db.Veterans.Add(veteran);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veteran);
        }
    }
}