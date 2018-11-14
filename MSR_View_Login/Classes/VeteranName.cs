using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MSR_Web_App.Models;

namespace MSR_Web_App.Classes
{
    public class VeteranName
    {
        private Msr_Database_Release_TwoEntities db = new Msr_Database_Release_TwoEntities();

        public string GetFullName(string Username)
        {
            Veteran veteran = db.Veterans.Find(Int32.Parse(Username));

            var fullName = veteran.FirstName + ", " +  veteran.Surname;

            return fullName;
        }
    }
    
}