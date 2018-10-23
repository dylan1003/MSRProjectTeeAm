namespace MSR_mvc.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MSRContext : DbContext
    {
        public MSRContext()
            : base("name=MSRContext")
        {
        }

        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<MultiMedia> MultiMedias { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<ProfilePicture> ProfilePictures { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VeteranQueue> VeteranQueues { get; set; }
        public virtual DbSet<Veteran> Veterans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Content>()
                .Property(e => e.source)
                .IsUnicode(false);

            modelBuilder.Entity<MultiMedia>()
                .HasMany(e => e.Contents)
                .WithRequired(e => e.MultiMedia)
                .HasForeignKey(e => e.Fk_MultiMedia_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Portfolio>()
                .HasMany(e => e.Sections)
                .WithRequired(e => e.Portfolio)
                .HasForeignKey(e => e.Fk_Portfolio_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Portfolio>()
                .HasMany(e => e.Veterans)
                .WithRequired(e => e.Portfolio)
                .HasForeignKey(e => e.Fk_Portfolio_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfilePicture>()
                .HasMany(e => e.Veterans)
                .WithRequired(e => e.ProfilePicture)
                .HasForeignKey(e => e.Fk_Profile_Picture_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Contents)
                .WithRequired(e => e.Section)
                .HasForeignKey(e => new { e.FK_Section_Id, e.FK_Portfolio_Id })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.VeteranQueues)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Fk_Teacher_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Veterans)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Fk_User_Id);

            modelBuilder.Entity<VeteranQueue>()
                .HasMany(e => e.Veterans)
                .WithOptional(e => e.VeteranQueue)
                .HasForeignKey(e => e.Fk_Veteran_Queue_Id);
        }
    }
}
