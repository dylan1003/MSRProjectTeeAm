using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MSR_mvc.Models;

namespace MSR_mvc.Controllers
{
    public class VeteransController : Controller
    {
        private MSRContext db = new MSRContext();

        
        //Just to test spike test of search layout/UI, Later to be used under index e.g Veterans/searchString?=James
        //Add Try catch to search items
        public ActionResult Index(string searchString, string inlineRadioOptions)
        {
            
            List<Veteran> veterans = db.Veterans.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                //Convert search string to lower case as .contains is case sensitive e.g James != james
                searchString = searchString.ToLower();

                if (inlineRadioOptions == "Name")
                {
                    veterans = veterans.Where(n => n.FirstName.ToLower().ToLower().Contains(searchString) ||
                                               n.MiddleName.ToLower().Contains(searchString) ||
                                               n.Surname.ToLower().Contains(searchString)).ToList();
                }
                else if (inlineRadioOptions == "Regiment")
                {
                    veterans = veterans.Where(n => n.ServiceNo.ToLower().Contains(searchString)).ToList();
                }
                else if (inlineRadioOptions == "Address")
                {
                    /* Currently country and town are null for veterans in db. Enable when data exists in db
                     *veterans = veterans.Where(n => n.Address.Contains(searchString) ||
                                                   n.Country.Contains(searchString) ||
                                                   n.Town.Contains(searchString)).ToList();
                    */
                    veterans = veterans.Where(n => n.Address.ToLower().Contains(searchString)).ToList();
                }
                else if (inlineRadioOptions == "Unit")
                {
                    veterans = veterans.Where(n => n.Unit.ToLower().Contains(searchString)).ToList();
                }
            }
            return View(veterans);
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