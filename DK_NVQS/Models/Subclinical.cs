using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class Subclinical
    {
        [Key]
        public int ID { get; set; }
        public virtual HealthRecord HealthRecord { get; set; }
        public int RecordID { get; set; }
        public virtual List<BloodTest> BloodTest { get; set; }
        public virtual List<BiochemicalTest> BiochemicalTest { get; set; }
        public virtual List<ImmunologicalTest> ImmunologicalTest { get; set; }
        public virtual List<UrineTest> UrineTest { get; set; }
        public string Radiography { get; set; }
        public string AbdominalUltrasound { get; set; }
        public string ECG { get; set; }
        public string OtherTests { get; set; }
    }
}