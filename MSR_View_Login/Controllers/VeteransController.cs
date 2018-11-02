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
        //Database connection
        private Msr_Database_Release_TwoEntities db = new Msr_Database_Release_TwoEntities();
        //View models
        PortfolioViewModel PortfolioModel = new PortfolioViewModel();
        VeteranSearchModel SearchModel = new VeteranSearchModel();

        //Returns a list of veterans, allows for search of msr & aif databases
        public ActionResult Index(string searchString, string searchType)
        {
            //List of veterans to search through 
            List<Veteran> veterans = db.Veterans.ToList();
            
            //Searches both MSR & AIF based on searchString and searchType
            if (!String.IsNullOrEmpty(searchString))
            {
                //Convert search string to lower case as .contains is case sensitive e.g James != james
                searchString = searchString.ToLower();

                if (searchType == "Name")
                {
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.FirstName) ? n.FirstName.ToLower().Contains(searchString) : false) ||
                                            (!String.IsNullOrEmpty(n.MiddleName) ? n.MiddleName.ToLower().Contains(searchString) : false) ||
                                            (!String.IsNullOrEmpty(n.Surname) ? n.Surname.ToLower().Contains(searchString) : false)).ToList();
                    SearchModel.AifResults = AifResult.AifSearch(searchString, searchType);
                }
                else if (searchType == "Regiment")
                {
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.RegimentNumber) ? n.RegimentNumber.ToLower().Contains(searchString) : false)).ToList();
                    SearchModel.AifResults = AifResult.AifSearch(searchString, searchType);
                }
                else if (searchType == "Address")
                {
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.Address) ? n.Address.ToLower().Contains(searchString) : false) ||
                                                   (!String.IsNullOrEmpty(n.Country) ? n.Country.ToLower().Contains(searchString) : false) ||
                                                   (!String.IsNullOrEmpty(n.State) ? n.State.ToLower().Contains(searchString) : false)).ToList();

                    SearchModel.AifResults = AifResult.AifSearch(searchString, searchType);
                }
                else if (searchType == "Unit")
                {
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.Battalion) ? n.Battalion.ToLower().Contains(searchString) : false)).ToList();
                }
                else if (searchType == "PreWarOccupation")
                {
                    SearchModel.Veteran = veterans.Where(n => (!String.IsNullOrEmpty(n.PreWarOccupation) ? n.PreWarOccupation.ToLower().Contains(searchString) : false)).ToList();
                }
            }
            else {
                SearchModel.Veteran = veterans;
            }
            return View(SearchModel);
        }



        // Displays veteran portfolio based on id
       public ActionResult Portfolio(int? id)
       {
            PortfolioModel.Veteran = db.Veterans.Find(id);
            PortfolioModel.Sections = db.Sections.Where(s => s.Veteran_Id == id).ToList();
            PortfolioModel.Contents = db.Contents.Where(c => c.Veteran_Id == id).ToList();

           return View(PortfolioModel);
        }
    
    }
}