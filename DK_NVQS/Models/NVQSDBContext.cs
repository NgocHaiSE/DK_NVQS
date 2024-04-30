using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DK_NVQS.Models
{
    public class NVQSDBContext : DbContext
    {
        public NVQSDBContext() : base("MyConnectionString") { }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<CurriculumVitae> CurriculumVitaes { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<Registration> Registrations { get; set; }  

    }
}