using KOCHospital.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOCHospital.Context
{
    public class HospitalContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PatientHistory> PatientHistories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server = UGUR; Database = KOCHospital; Trusted_Connection = True; TrustServerCertificate = True");

                optionsBuilder.UseSqlServer("Server = UGUR; Database = KOCHospital; Trusted_Connection = True; TrustServerCertificate = True");
            }

            optionsBuilder.UseLazyLoadingProxies();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Doctor>().ToTable("Doctor");
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<PatientHistory>().ToTable("PatientHistory");


            modelBuilder.Entity<Doctor>().HasOne<Appointment>().WithOne(x => x.Doctor).HasForeignKey<Appointment>(x => x.DoctorId);
            modelBuilder.Entity<Patient>().HasOne<Appointment>().WithOne(x => x.Patient).HasForeignKey<Appointment>(x => x.PatientId);
            
            //modelBuilder.Entity<Appointment>().HasOne(a => a.Patient).WithMany(p => p.Appointments).HasForeignKey(a => a.PatientId);
            
            modelBuilder.Entity<Appointment>().HasOne(a => a.Patient).WithMany(p => p.Appointments).HasForeignKey(a => a.PatientId);


            

        }




    }
}
