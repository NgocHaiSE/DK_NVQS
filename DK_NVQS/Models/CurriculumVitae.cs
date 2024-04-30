using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DK_NVQS.Models
{
    public class CurriculumVitae
    {
        [Key]
        public int QurriculumVitaeID {  get; set; }
        public string CitizenID { get; set; }
        public string PhotoPath { get; set; }
        public string JobBefore { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public Nullable<int> FatherBornYear { get; set; }
        public Nullable<int> MotherBornYear { get; set; }
        public string FatherJob { get; set; }
        public string MotherJob { get; set; }
        public string Domicile { get; set; }
        public string Residence { get; set; }
        public string FamilyAnamnesis { get; set; }
        public string SelfAnamnesis { get; set; }
        public Nullable<DateTime> Date { get; set; }
        public virtual Citizen Citizen { get; set; }  
    }
}