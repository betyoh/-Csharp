namespace lab2._1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Agency2_Model1 : DbContext
    {
        public Agency2_Model1()
            : base("name=Agency2_Model1")
        {
        }

        public virtual DbSet<travelAgency> travelAgency { get; set; }
        public virtual DbSet<Traveller> Traveller { get; set; }
        public virtual DbSet<Trip> Trip { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<travelAgency>()
                .Property(e => e.namn)
                .IsUnicode(false);

            modelBuilder.Entity<Traveller>()
                .Property(e => e.fistName)
                .IsUnicode(false);

            modelBuilder.Entity<Traveller>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Traveller>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Trip>()
                .Property(e => e.stad)
                .IsUnicode(false);

            modelBuilder.Entity<Trip>()
                .Property(e => e.pris)
                .IsUnicode(false);
        }
    }
}
