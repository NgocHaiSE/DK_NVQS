using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class ImmunologicalTest
    {
        [Key]
        public int Id { get; set; }
        public virtual Subclinical Subclinical { get; set; }
        public int SubclinicalID { get; set; }
        public string HBsAg { get; set; }
        public string AntiHCV { get; set; }
    }
}