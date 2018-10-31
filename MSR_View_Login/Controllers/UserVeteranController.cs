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
        public ActionResult Portfolio()
        {
            int userID = Convert.ToInt32(User.Identity.GetUserName());
            // Get veteran from login info 
            viewModel.Veteran = db.Veterans.SingleOrDefault(v => v.Id == userID);
            viewModel.Sections = db.Sections.Where(s => s.Veteran.Id ==userID).ToList();

            return View("Portfolio", viewModel);
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

            return RedirectToAction("Portfolio", viewModel);
        }

        public ActionResult AddContent(Content content)
        {

            // get current sections
            viewModel.Sections = db.Sections.ToList();

            Section currentSection = db.Sections.SingleOrDefault(s => s.Id == content.Section.Id);
            content.Section.Id = currentSection.Id;

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

            db.Contents.Add(content);
            db.SaveChanges();

            return RedirectToAction("Portfolio", viewModel);
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