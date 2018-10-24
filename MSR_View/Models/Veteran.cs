namespace MSR_mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Veteran
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(20)]
        public string DOB { get; set; }

        [StringLength(50)]
        public string Fate { get; set; }

        [StringLength(20)]
        public string Death { get; set; }

        [StringLength(20)]
        public string EnlistedDate { get; set; }

        [StringLength(10)]
        public string ServiceNo { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string Parish { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(1000)]
        public string ShortBio { get; set; }

        public int? Status { get; set; }

        public int? Fk_User_Id { get; set; }

        public int Fk_Profile_Picture_Id { get; set; }

        public int Fk_Portfolio_Id { get; set; }

        public int? Fk_Veteran_Queue_Id { get; set; }

        public virtual Portfolio Portfolio { get; set; }

        public virtual ProfilePicture ProfilePicture { get; set; }

        public virtual User User { get; set; }

        public virtual VeteranQueue VeteranQueue { get; set; }
    }
}
