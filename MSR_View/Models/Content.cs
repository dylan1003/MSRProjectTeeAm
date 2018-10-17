namespace MSR_mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Content
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public DateTime Timestamp { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }

        [Column(TypeName = "text")]
        public string source { get; set; }

        public int DisplayPosition { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FK_Section_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FK_Portfolio_Id { get; set; }

        public int Fk_MultiMedia_Id { get; set; }

        public virtual Section Section { get; set; }

        public virtual MultiMedia MultiMedia { get; set; }
    }
}
