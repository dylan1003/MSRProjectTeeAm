using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSR_mvc.Models;

namespace MSR_mvc.Controllers
{
    public class VeteransController : Controller
    {
        private MSRContext db = new MSRContext();

        // GET: Index
        public ActionResult Index()
        {
            return View(db.Veterans.ToList());
        }
        // Get By Id
        public ActionResult Portfolio(int? id)
        {
            Veteran veteran = db.Veterans.Find(id);
            ProfilePicture picture = db.ProfilePictures.Find(veteran.Fk_Profile_Picture_Id);
            Console.WriteLine(picture);
            Portfolio portfolio = db.Portfolios.Find(veteran.Fk_Portfolio_Id);
            List<Section> DisplaySections = new List<Section>();
            List<Content> Content = new List<Content>();

            foreach (var item in db.Sections.ToList())
            {
                if (item.Fk_Portfolio_Id == portfolio.Id)
                {
                    DisplaySections.Add(item);
                }
            }

            return View(Tuple.Create(DisplaySections, veteran, picture));
        }
    }
}