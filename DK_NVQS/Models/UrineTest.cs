using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class UrineTest
    {
        [Key]
        public int Id { get; set; }
        public virtual Subclinical Subclinical { get; set; }
        public int SubclinicalID { get; set; }
        public string SpecificGravity { get; set; }
        public string pH { get; set; }
        public string BC { get; set; }
        public string HC { get; set; }
        public string Nitrit { get; set; }
        public string Protein { get; set; }
        public string Glucose { get; set; }
        public string Cetonic { get; set; }
        public string Bilirubin { get; set; }
        public string Urobilinogen { get; set; }
    }
}