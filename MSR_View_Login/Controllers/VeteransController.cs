using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MSR_Web_App.Classes;
using MSR_Web_App.Models;

namespace MSR_Web_App.Controllers
{
    public class VeteransController : Controller
    {
        private Msr_Database_Release_TwoEntities db = new Msr_Database_Release_TwoEntities();
        PortfolioViewModel PortfolioModel = new PortfolioViewModel();
        VeteranSearchModel SearchModel = new VeteranSearchModel();

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
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.FirstName) ? n.FirstName.ToLower().Contains(searchString) : false) ||
                                            (!String.IsNullOrEmpty(n.MiddleName) ? n.MiddleName.ToLower().Contains(searchString) : false) ||
                                            (!String.IsNullOrEmpty(n.Surname) ? n.Surname.ToLower().Contains(searchString) : false)).ToList();
                    SearchModel.AifResults = AifResult.AifSearch(searchString, inlineRadioOptions);
                }
                else if (inlineRadioOptions == "Regiment")
                {
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.RegimentNumber) ? n.RegimentNumber.ToLower().Contains(searchString) : false)).ToList();
                    SearchModel.AifResults = AifResult.AifSearch(searchString, inlineRadioOptions);
                }
                else if (inlineRadioOptions == "Address")
                {
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.Address) ? n.Address.ToLower().Contains(searchString) : false) ||
                                                   (!String.IsNullOrEmpty(n.Country) ? n.Country.ToLower().Contains(searchString) : false) ||
                                                   (!String.IsNullOrEmpty(n.State) ? n.State.ToLower().Contains(searchString) : false)).ToList();

                    SearchModel.AifResults = AifResult.AifSearch(searchString, inlineRadioOptions);
                }
                else if (inlineRadioOptions == "Unit")
                {
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.Battalion) ? n.Battalion.ToLower().Contains(searchString) : false)).ToList();
                }
                else if (inlineRadioOptions == "PreWarOccupation")
                {
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.PreWarOccupation) ? n.PreWarOccupation.ToLower().Contains(searchString) : false)).ToList();
                }
            }
            else {
                SearchModel.Veteran = veterans;
            }
            return View(SearchModel);
        }



        // Get By Id
        
       public ActionResult Portfolio(int? id)
       {
            PortfolioModel.Veteran = db.Veterans.Find(id);
            PortfolioModel.Sections = db.Sections.Where(s => s.Veteran_Id == id).ToList();
            PortfolioModel.Contents = db.Contents.Where(c => c.Veteran_Id == id).ToList();
            //Portfolio portfolio = db.Portfolios.Find(veteran.Fk_Portfolio_Id);

           return View(PortfolioModel);
        }
    
    }
}