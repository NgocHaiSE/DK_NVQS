using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace DK_NVQS.Models
{
    public class Citizen
    {
        [Key]
        public string CitizenID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Hometown { get; set; }
        public Nullable<int> Age { get; set; }
        public string Status { get; set; }
        public Nullable<bool> Eligible { get; set; }
        public Nullable<bool> Ready { get; set; }
        public virtual List<Registration> Registrations { get; set; }
        public virtual HealthRecord HealthRecord { get; set; }
        public virtual CurriculumVitae QurriculumVitae { get; set; }

        public int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if(dateOfBirth > today.AddYears(-age))
            {
                age--;
            }
            return age;     
        }
        
    }


}