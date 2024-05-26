using DK_NVQS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DK_NVQS.ViewModel
{
    public class HealthRecordListVM
    {
        public string CitizenID { get; set; }
        public int? Year { get; set; }
        public bool? IsSubclinical { get; set; }
        public bool? IsClinical { get; set; }
        public List<DK_NVQS.Models.HealthRecord> HealthRecords { get; set; }
    }
}