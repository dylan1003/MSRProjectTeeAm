using MSR_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSR_Web_App.Models
{
    public class PortfolioCreateViewModel
    {
        public Veteran Veteran { get; set; }
        public List<Section> Sections { get; set; }
        public List<Content> Contents { get; set; }
        public Section section { get; set; }
        public Content content { get; set; }

    }
}