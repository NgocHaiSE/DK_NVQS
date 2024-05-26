using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class PhysicalStrength
    {
        [Key]
        public int Id { get; set; }
        public virtual Clinical Clinical { get; set; }
        public int ClinicalID { get; set; }
        public string Score { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }
        public double ChestCircumference { get; set; }
        public string DoctorSignature { get; set; }
    }
}