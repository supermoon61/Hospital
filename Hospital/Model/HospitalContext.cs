using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    class HospitalContext : DbContext
    {
        public HospitalContext()
            : base("name=HospitalContext")
        {
            Database.SetInitializer<HospitalContext>(new CreateDatabaseIfNotExists<HospitalContext>());
            Database.SetInitializer<HospitalContext>(new DBInitializer());
            //  Database.SetInitializer<HospitalContext>(null);
        }

       
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Issued> MedicineIssue { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //User Properties and Relation with other.

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            //Patient Relation With Branch Session Fee and Payment 

            modelBuilder.Entity<Patient>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.FatherOrHusband)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Gender)
                .IsUnicode(false);

           

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.MedicineIssued)
                .WithRequired(s => s.Patient)
                .HasForeignKey(s => s.PID);

           
        }
    }
}
