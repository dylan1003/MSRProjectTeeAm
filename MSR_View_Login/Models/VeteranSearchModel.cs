using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MSR_Web_App.Classes;

namespace MSR_Web_App.Models
{
    public class VeteranSearchModel
    {
        public List<Veteran> Veteran { get; set; }
        public List<AifResult> AifResults { get; set; }
    }
}