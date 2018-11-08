using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSR_Web_App.Models;
using Microsoft.AspNet.Identity;
using System.IO;

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
                
        public ActionResult EditSectionMap(Section section)
        {
            Section sectionToUpdate = new Section();

            return View("PortfolioCreation", viewModel);
        }

        public ActionResult _MapModal()
        {
            Section section = new Section();
            section.EventTitle = "fuk";
            return PartialView(section);
        }

        public ActionResult EditProfilePicture(Veteran veteran)
        {
            Veteran veteranToUpdate = db.Veterans.Single(v => v.Id == veteran.Id);

            veteranToUpdate.ProfilePicture = veteran.ProfilePicture;

            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

            return RedirectToAction("PortfolioCreation", viewModel);
        }

        public ActionResult EditSection(Content content, Section section, string editSection)
        {
            
            // get ALL current sections
            viewModel.Sections = db.Sections.ToList();

            if (editSection == "AddContent")
            {
                // get current sections
                viewModel.Sections = db.Sections.ToList();
                int vetId = Int32.Parse(User.Identity.GetUserName());
                Veteran veteran = db.Veterans.SingleOrDefault(v => v.Id == vetId);
                Section currentSection = db.Sections.FirstOrDefault(s => s.Id == content.Section_Id);
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

                content.Veteran_Id = Int32.Parse(User.Identity.GetUserName());

                db.Contents.Add(content);
                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
                
            }
            else if (editSection == "Delete")
            {
                // Delete contents for section first
                foreach (Content c in db.Contents)
                {
                    if (c.Section_Id == section.Id && section.Veteran_Id == c.Veteran_Id)
                    {
                        db.Contents.Remove(c);
                    }
                }

                // Delete section
                Section sectionToDelete = db.Sections.SingleOrDefault(s => s.Id == section.Id && s.Veteran_Id == section.Veteran_Id);
                db.Sections.Remove(sectionToDelete);
            }

            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

            return RedirectToAction("PortfolioCreation", viewModel);
        }

        public ActionResult AddSection(Section section)
        {
            int veteranId = Convert.ToInt32(User.Identity.GetUserName());

            viewModel.Sections = db.Sections.Where(s => s.Veteran_Id == veteranId).ToList();

            // find next Id for section (largest)
            
            int nextId = 0;

            if (viewModel.Sections.Count == 0)
            {
                section.Id = 1;
            }
            else
            {
                foreach (Section s in viewModel.Sections)
                {
                    if (s.Id > nextId)
                    {
                        nextId = s.Id;
                    }
                    section.Id = nextId + 1;
                }
            }

            db.Sections.Add(section);

            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

            return RedirectToAction("PortfolioCreation", viewModel);
        }

        public ActionResult EditContent(Content content, string editContent)
        {

            content.Veteran_Id = Int32.Parse(User.Identity.GetUserName());

            if (editContent == "Save")
            {
                Content contentToSave = db.Contents.Single(c => c.Id == content.Id && c.Section_Id == content.Section_Id && c.Veteran_Id == content.Veteran_Id);
                contentToSave.Title = content.Title;
                contentToSave.Timestamp = content.Timestamp;
                contentToSave.MediaType = content.MediaType;
                contentToSave.Media = content.Media;
                contentToSave.Source = content.Source;
                contentToSave.DisplayPosition = content.DisplayPosition;
            }
            else if (editContent == "Delete")
            {
                Content contentToDelete = db.Contents.SingleOrDefault(c => c.Id == content.Id && c.Section_Id == content.Section_Id && content.Veteran_Id == c.Veteran_Id);
                db.Contents.Remove(contentToDelete);
            }

            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

            return RedirectToAction("PortfolioCreation", viewModel);
        }

        public ActionResult UploadImage(HttpPostedFileBase file)
        {
            if (file != null)
            {
                string pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/images/profile"), pic);
                // file is uploaded
                file.SaveAs(path);

                // save the image path path to the database or you can send image 
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }

            }
            // after successfully uploading redirect the user
            return RedirectToAction("PortfolioCreation", viewModel);
        }
    }
}