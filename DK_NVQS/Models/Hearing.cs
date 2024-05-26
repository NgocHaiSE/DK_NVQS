using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class Hearing
    {
        [Key]
        public int Id { get; set; }
        public virtual Clinical Clinical { get; set; }
        public int ClinicalID { get; set; }
        public string RightEar { get; set; }
        public string LeftEar { get; set; }
    }
}