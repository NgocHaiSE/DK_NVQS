using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationFormID  { get; set; }
        public string CitizenID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Date {  get; set; }
        public int NumberOfPostponements { get; set; }
        public int NumberOfRegisters { get; set; }
        public int NumberOfExemptions { get; set; }
        public string Status {  get; set; }
        public virtual Citizen Citizen { get; set; }
    }
}