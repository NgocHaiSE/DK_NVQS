using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class BloodTest
    {
        [Key]
        public int Id { get; set; }
        public virtual Subclinical Subclinical { get; set; }
        public int SubclinicalID { get; set; }
        public string HC { get; set; }
        public string HST { get; set; }
        public string TC { get; set; }
        public string BC { get; set; }
        public string CTBC { get; set; }
        public string BloodType { get; set; }
    }
}