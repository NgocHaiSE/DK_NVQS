using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class Clinical
    {
        [Key]
        public int ID { get; set; }
        public virtual HealthRecord HealthRecord { get; set; }
        public int RecordID { get; set; }
        public virtual List<PhysicalStrength> PhysicalStrength { get; set; }
        public virtual List<Eyes> Eyes { get; set; }
        public virtual List<ENT> ENT { get; set; }
        public virtual List<DentalOral> DentalOral { get; set; }
        public virtual List<InternalMedicine> InternalMedicine { get; set; }
        public virtual List<Neurology> Neurology { get; set; }
        public virtual List<Surgery> Surgery { get; set; }
        public virtual List<Dermatology> Dermatology { get; set; }
        public string Conclusion { get; set; }
    }
}