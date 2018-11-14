using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSR_Web_App.Classes
{
    public class AifResult
    {
        public string RegimentNumber { get; set; }
        
        public string Name { get; set; }
        
        public string ProfileLink { get; set; }
        
        public string Address { get; set; }

        public string Battalion { get; set; }

        public static List<AifResult> AifSearch(string search, string searchType)
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
    }
}