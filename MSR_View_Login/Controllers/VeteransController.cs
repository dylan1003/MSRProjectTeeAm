using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MSR_Web_App.Models;

namespace MSR_Web_App.Controllers
{
    public class VeteransController : Controller
    {
        private Msr_Database_Release_TwoEntities db = new Msr_Database_Release_TwoEntities();
        PortfolioViewModel PortfolioModel = new PortfolioViewModel();

        public List<AifResult> AifSearch(string search, string searchType)
        {
            List<AifResult> resultsList = new List<AifResult>();
            string baseAddress = "https://www.aif.adfa.edu.au/";
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load($"{baseAddress}");

            if (searchType == "Name")
            {
                doc = web.Load($"{baseAddress}search?type=search&name={search}");
            }
            else if (searchType == "Regiment")
            {
                doc = web.Load($"{baseAddress}search?type=search&regNum={search}");
            }
            else if (searchType == "Address")
            {
                doc = web.Load($"{baseAddress}search?type=search&place={search}");
            }

            var listings = doc.DocumentNode.SelectNodes("//tr");

            foreach (var item in listings.Where(l => l != listings.Last()))
            {
                AifResult results = new AifResult();

                results.RegimentNumber = item.ChildNodes[1].InnerHtml;
                results.Name = item.ChildNodes[2].InnerText;
                results.ProfileLink = baseAddress + item.ChildNodes[2].ChildNodes[0].Attributes[0].Value;
                results.Address = item.ChildNodes[3].InnerHtml;
                results.Battalion = item.ChildNodes[4].InnerText;

                resultsList.Add(results);
            }
            return resultsList;
        }


        //Just to test spike test of search layout/UI, Later to be used under index e.g Veterans/searchString?=James
        //Add Try catch to search items
        public ActionResult Index(string searchString, string inlineRadioOptions)
        {
            List<AifResult> searchResults = new List<AifResult>();
            List<Veteran> veterans = db.Veterans.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                //Convert search string to lower case as .contains is case sensitive e.g James != james
                searchString = searchString.ToLower();

                if (inlineRadioOptions == "Name")
                {
                    
                    veterans = veterans.Where(n => (!String.IsNullOrEmpty(n.FirstName) ? n.FirstName.ToLower().Contains(searchString): false) ||
                                            (!String.IsNullOrEmpty(n.MiddleName) ? n.MiddleName.ToLower().Contains(searchString) : false) ||
                                            (!String.IsNullOrEmpty(n.Surname) ? n.Surname.ToLower().Contains(searchString) : false)).ToList();
                    searchResults = AifSearch(searchString, inlineRadioOptions);
                }
                else if (inlineRadioOptions == "Regiment")
                {
                    veterans = veterans.Where(n => (!String.IsNullOrEmpty(n.RegimentNumber) ? n.RegimentNumber.ToLower().Contains(searchString) : false)).ToList();
                    searchResults = AifSearch(searchString, inlineRadioOptions);
                }
                else if (inlineRadioOptions == "Address")
                {
                    // Currently country and town are null for veterans in db. Enable when data exists in db
                    veterans = veterans.Where(n => (!String.IsNullOrEmpty(n.Address) ? n.Address.ToLower().Contains(searchString) : false) ||
                                                   (!String.IsNullOrEmpty(n.Country) ? n.Country.ToLower().Contains(searchString) : false) ||
                                                   (!String.IsNullOrEmpty(n.State) ? n.State.ToLower().Contains(searchString) : false)).ToList();
                    
                    searchResults = AifSearch(searchString, inlineRadioOptions);
                }
                else if (inlineRadioOptions == "Unit")
                {
                    veterans = veterans.Where(n => (!String.IsNullOrEmpty(n.Battalion) ? n.Battalion.ToLower().Contains(searchString) : false)).ToList();
                }
            }
            return View(Tuple.Create(veterans, searchResults));
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