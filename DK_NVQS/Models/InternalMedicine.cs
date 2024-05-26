using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class InternalMedicine
    {
        [Key]
        public int Id { get; set; }
        public virtual Clinical Clinical { get; set; }
        public int ClinicalID { get; set; }
        public string Score { get; set; }
        public string PulseRate { get; set; }
        public string BloodPressure { get; set; }
        public string DoctorSignature { get; set; }
    }
}