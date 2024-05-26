using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class HealthRecord
    {
        [Key]
        public int RecordID { get; set; }
        public virtual List<Subclinical> Subclinicals { get; set; }
        public virtual List<Clinical> Clinicals { get; set; }
        public virtual Citizen Citizen { get; set; }
        public DateTime Date {  get; set; }
    }
}