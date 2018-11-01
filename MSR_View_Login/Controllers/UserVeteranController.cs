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
        private Msr_Database_Release_TwoEntities db = new Msr_Database_Release_TwoEntities();
        PortfolioCreateViewModel viewModel = new PortfolioCreateViewModel();

        // GET: Veteran
        public ActionResult PortfolioCreation()
        {
            int userID = Convert.ToInt32(User.Identity.GetUserName());
            // Get veteran from login info 
            viewModel.Veteran = db.Veterans.SingleOrDefault(v => v.Id == userID);
            viewModel.Sections = db.Sections.Where(s => s.Veteran.Id ==userID).ToList();

            return View("PortfolioCreation", viewModel);
        }

        public ActionResult Manage()
        {
            return View();
        }

        public ActionResult AddSection(Section section)
        {
            // get ALL current sections
            viewModel.Sections = db.Sections.ToList();

            // find next Id for section (largest)
            int nextId = 0;
            foreach (Section s in viewModel.Sections)
            {
                if (s.Id > nextId)
                {
                    nextId = s.Id;
                }

            }

            section.Id = nextId + 1;

            db.Sections.Add(section);
            db.SaveChanges();

            return RedirectToAction("PortfolioCreation", viewModel);
        }

        public ActionResult AddContent(Content content)
        {

            // get current sections
            viewModel.Sections = db.Sections.ToList();
            int vetId = Int32.Parse(User.Identity.GetUserName());
            Veteran veteran = db.Veterans.SingleOrDefault(v => v.Id == vetId);
            Section currentSection = db.Sections.SingleOrDefault(s => s.Id == content.FK_Section_Id);
            //content.FK_Section_Id = currentSection.Id;
            content.Section = currentSection;

            content.Section.Veteran = veteran;

            // find next Id for section (largest)
            int nextId = 0;
            foreach (Content c in currentSection.Contents)
            {
                if (c.Id > nextId)
                {
                    nextId = c.Id;
                }

            }

            content.Id = nextId + 1;

            content.FK_Veterans_Id = Int32.Parse(User.Identity.GetUserName());

            db.Contents.Add(content);
            db.SaveChanges();

            return RedirectToAction("PortfolioCreation", viewModel);
        }

        public ActionResult DeleteContent(Content content)
        {

            Content contentToDelete = db.Contents.SingleOrDefault(c => c.Id == content.Id && c.Section.Id == content.Section.Id);
            db.Contents.Remove(contentToDelete);
            db.SaveChanges();

            return RedirectToAction("Index", viewModel);
        }

    }
}