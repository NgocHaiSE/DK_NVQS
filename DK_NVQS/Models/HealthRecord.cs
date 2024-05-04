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
        public string CBC { get; set; }
        public string BloodGroup { get; set; }
        public string Biochemical { get; set; }
        public string Immunity { get; set; }
        public string Xray { get; set; }
        public string StomachSupersonic { get; set; }
        public string ECG { get; set; }
        public string OtherTests { get; set; }
        public Nullable<float> Height { get; set; }
        public Nullable<float> Weight { get; set; }
        public Nullable<float> BMI { get; set; }
        public Nullable<float> Chest { get; set; }
        public string GlassRight { get; set; }
        public string GlassLeft { get; set; }
        public string NoGlassRight { get; set; }
        public string NoGlassLeft { get; set; }
        public string PathologicalEyes { get; set; }
        public Nullable<float> NormalRight { get; set; }
        public Nullable<float> NormalLeft { get; set; }
        public Nullable<float> WhisperLeft { get; set; }
        public Nullable<float> WhisperRight { get; set; }
        public string PathologicalENT { get; set; }
        public string DOL { get; set; }
        public Nullable<float> Circuit { get; set; }
        public Nullable<float> BloodPressure { get; set; }
        public string PathologicalMedical { get; set; }
        public string Neuropsychiatric { get; set; }
        public string Surgery { get; set; }
        public string Dermatology { get; set; }
        public string Conclusion { get; set; }
        public string PhysicalPoint { get; set; }
        public string EyePoint { get; set; }
        public string ENTPoint { get; set; }
        public string DOLPoint { get; set; }
        public string MedicalPoint { get; set; }
        public string NeuropsychiatricPoint { get; set; }
        public string SurgeryPoint { get; set; }
        public string DermatologyPoint { get; set; }
        public string ConclusionPoint { get; set; }
        public virtual Citizen Citizen { get; set; }
    }
}