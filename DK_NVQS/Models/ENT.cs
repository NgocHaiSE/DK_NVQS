using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class ENT
    {
        [Key]
        public int ID { get; set; }
        public int ClinicalID { get; set; }
        public virtual Clinical Clinical { get; set; }
        public string Score { get; set; }
        public Hearing NormalSpeak { get; set; }
        public Hearing WhisperSpeak { get; set; }
        public string DoctorSignature { get; set; }
    }
}