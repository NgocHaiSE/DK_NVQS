using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class Eyes
    {
        [Key]
        public int Id { get; set; }
        public virtual Clinical Clinical { get; set; }
        public int ClinicalID { get; set; }
        public string Score { get; set; }
        public Vision WithoutGlasses { get; set; }
        public Vision WithGlasses { get; set; }
        public string DoctorSignature { get; set; }
    }
}