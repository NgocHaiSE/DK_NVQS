using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DK_NVQS.Models
{
    public class NVQSDBContext : DbContext
    {
        public NVQSDBContext() : base("DbNVQS") { }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<CurriculumVitae> CurriculumVitaes { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Clinical> Clinicals { get; set; }
        public DbSet<Subclinical> Subclinicals { get; set; }
        public DbSet<BiochemicalTest> BiochemicalTests { get; set; }
        public DbSet<BloodTest> BloodTests { get; set; }
        public DbSet<DentalOral> DentalOrals { get; set; }
        public DbSet<Dermatology> DermatologyTests { get; set;}
        public DbSet<ENT> ENTS { get; set; }
        public DbSet<Eyes> Eyes { get; set; }
        public DbSet<Hearing> Hearings { get; set; }
        public DbSet<ImmunologicalTest> ImmunologicalTests { get; set ; }
        public DbSet<InternalMedicine> InternalMedicineTests { get;set; }
        public DbSet<Neurology> NeurologyTests { get; set;}
        public DbSet<PhysicalStrength> PhysicalStrengthTests { get; set; }
        public DbSet<Surgery> SurgeryTests { get; set;}
        public DbSet<UrineTest> UrineTests { get; set;}
        public DbSet<Vision> Visions { get; set; }
        
    }
}