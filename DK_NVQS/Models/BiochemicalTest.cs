using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class BiochemicalTest
    {
        [Key]
        public int ID { get; set; }
        public virtual Subclinical Subclinical { get; set; }
        public int SubclinicalID { get; set; }
        public string AST { get; set; }
        public string ALT { get; set; }
        public string Ure { get; set; }
        public string Creatinin { get; set; }
        public string Glucose { get; set; }
    }
}