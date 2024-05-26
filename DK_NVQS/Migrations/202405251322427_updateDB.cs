namespace DK_NVQS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinicals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RecordID = c.Int(nullable: false),
                        Conclusion = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HealthRecords", t => t.RecordID, cascadeDelete: true)
                .Index(t => t.RecordID);
            
            CreateTable(
                "dbo.DentalOrals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        Score = c.String(),
                        Reason = c.String(),
                        DoctorSignature = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .Index(t => t.ClinicalID);
            
            CreateTable(
                "dbo.Dermatologies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        Score = c.String(),
                        Reason = c.String(),
                        DoctorSignature = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .Index(t => t.ClinicalID);
            
            CreateTable(
                "dbo.ENTs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        Score = c.String(),
                        DoctorSignature = c.String(),
                        NormalSpeak_Id = c.Int(),
                        WhisperSpeak_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .ForeignKey("dbo.Hearings", t => t.NormalSpeak_Id)
                .ForeignKey("dbo.Hearings", t => t.WhisperSpeak_Id)
                .Index(t => t.ClinicalID)
                .Index(t => t.NormalSpeak_Id)
                .Index(t => t.WhisperSpeak_Id);
            
            CreateTable(
                "dbo.Hearings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        RightEar = c.String(),
                        LeftEar = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .Index(t => t.ClinicalID);
            
            CreateTable(
                "dbo.Eyes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        Score = c.String(),
                        DoctorSignature = c.String(),
                        WithGlasses_Id = c.Int(),
                        WithoutGlasses_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .ForeignKey("dbo.Visions", t => t.WithGlasses_Id)
                .ForeignKey("dbo.Visions", t => t.WithoutGlasses_Id)
                .Index(t => t.ClinicalID)
                .Index(t => t.WithGlasses_Id)
                .Index(t => t.WithoutGlasses_Id);
            
            CreateTable(
                "dbo.Visions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        RightEye = c.String(),
                        LeftEye = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .Index(t => t.ClinicalID);
            
            CreateTable(
                "dbo.InternalMedicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        Score = c.String(),
                        PulseRate = c.String(),
                        BloodPressure = c.String(),
                        DoctorSignature = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .Index(t => t.ClinicalID);
            
            CreateTable(
                "dbo.Neurologies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        Score = c.String(),
                        Reason = c.String(),
                        DoctorSignature = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .Index(t => t.ClinicalID);
            
            CreateTable(
                "dbo.PhysicalStrengths",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        Score = c.String(),
                        Height = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        BMI = c.Double(nullable: false),
                        ChestCircumference = c.Double(nullable: false),
                        DoctorSignature = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .Index(t => t.ClinicalID);
            
            CreateTable(
                "dbo.Surgeries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicalID = c.Int(nullable: false),
                        Score = c.String(),
                        Reason = c.String(),
                        DoctorSignature = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicals", t => t.ClinicalID, cascadeDelete: true)
                .Index(t => t.ClinicalID);
            
            CreateTable(
                "dbo.Subclinicals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Radiography = c.String(),
                        AbdominalUltrasound = c.String(),
                        ECG = c.String(),
                        OtherTests = c.String(),
                        HealthRecord_RecordID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HealthRecords", t => t.HealthRecord_RecordID)
                .Index(t => t.HealthRecord_RecordID);
            
            CreateTable(
                "dbo.BiochemicalTests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubclinicalID = c.Int(nullable: false),
                        AST = c.String(),
                        ALT = c.String(),
                        Ure = c.String(),
                        Creatinin = c.String(),
                        Glucose = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Subclinicals", t => t.SubclinicalID, cascadeDelete: true)
                .Index(t => t.SubclinicalID);
            
            CreateTable(
                "dbo.BloodTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubclinicalID = c.Int(nullable: false),
                        HC = c.String(),
                        HST = c.String(),
                        TC = c.String(),
                        BC = c.String(),
                        CTBC = c.String(),
                        BloodType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subclinicals", t => t.SubclinicalID, cascadeDelete: true)
                .Index(t => t.SubclinicalID);
            
            CreateTable(
                "dbo.ImmunologicalTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubclinicalID = c.Int(nullable: false),
                        HBsAg = c.String(),
                        AntiHCV = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subclinicals", t => t.SubclinicalID, cascadeDelete: true)
                .Index(t => t.SubclinicalID);
            
            CreateTable(
                "dbo.UrineTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubclinicalID = c.Int(nullable: false),
                        SpecificGravity = c.String(),
                        pH = c.String(),
                        BC = c.String(),
                        HC = c.String(),
                        Nitrit = c.String(),
                        Protein = c.String(),
                        Glucose = c.String(),
                        Cetonic = c.String(),
                        Bilirubin = c.String(),
                        Urobilinogen = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subclinicals", t => t.SubclinicalID, cascadeDelete: true)
                .Index(t => t.SubclinicalID);
            
            DropColumn("dbo.HealthRecords", "CBC");
            DropColumn("dbo.HealthRecords", "BloodGroup");
            DropColumn("dbo.HealthRecords", "Biochemical");
            DropColumn("dbo.HealthRecords", "Immunity");
            DropColumn("dbo.HealthRecords", "Xray");
            DropColumn("dbo.HealthRecords", "StomachSupersonic");
            DropColumn("dbo.HealthRecords", "ECG");
            DropColumn("dbo.HealthRecords", "OtherTests");
            DropColumn("dbo.HealthRecords", "Height");
            DropColumn("dbo.HealthRecords", "Weight");
            DropColumn("dbo.HealthRecords", "BMI");
            DropColumn("dbo.HealthRecords", "Chest");
            DropColumn("dbo.HealthRecords", "GlassRight");
            DropColumn("dbo.HealthRecords", "GlassLeft");
            DropColumn("dbo.HealthRecords", "NoGlassRight");
            DropColumn("dbo.HealthRecords", "NoGlassLeft");
            DropColumn("dbo.HealthRecords", "PathologicalEyes");
            DropColumn("dbo.HealthRecords", "NormalRight");
            DropColumn("dbo.HealthRecords", "NormalLeft");
            DropColumn("dbo.HealthRecords", "WhisperLeft");
            DropColumn("dbo.HealthRecords", "WhisperRight");
            DropColumn("dbo.HealthRecords", "PathologicalENT");
            DropColumn("dbo.HealthRecords", "DOL");
            DropColumn("dbo.HealthRecords", "Circuit");
            DropColumn("dbo.HealthRecords", "BloodPressure");
            DropColumn("dbo.HealthRecords", "PathologicalMedical");
            DropColumn("dbo.HealthRecords", "Neuropsychiatric");
            DropColumn("dbo.HealthRecords", "Surgery");
            DropColumn("dbo.HealthRecords", "Dermatology");
            DropColumn("dbo.HealthRecords", "Conclusion");
            DropColumn("dbo.HealthRecords", "PhysicalPoint");
            DropColumn("dbo.HealthRecords", "EyePoint");
            DropColumn("dbo.HealthRecords", "ENTPoint");
            DropColumn("dbo.HealthRecords", "DOLPoint");
            DropColumn("dbo.HealthRecords", "MedicalPoint");
            DropColumn("dbo.HealthRecords", "NeuropsychiatricPoint");
            DropColumn("dbo.HealthRecords", "SurgeryPoint");
            DropColumn("dbo.HealthRecords", "DermatologyPoint");
            DropColumn("dbo.HealthRecords", "ConclusionPoint");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HealthRecords", "ConclusionPoint", c => c.String());
            AddColumn("dbo.HealthRecords", "DermatologyPoint", c => c.String());
            AddColumn("dbo.HealthRecords", "SurgeryPoint", c => c.String());
            AddColumn("dbo.HealthRecords", "NeuropsychiatricPoint", c => c.String());
            AddColumn("dbo.HealthRecords", "MedicalPoint", c => c.String());
            AddColumn("dbo.HealthRecords", "DOLPoint", c => c.String());
            AddColumn("dbo.HealthRecords", "ENTPoint", c => c.String());
            AddColumn("dbo.HealthRecords", "EyePoint", c => c.String());
            AddColumn("dbo.HealthRecords", "PhysicalPoint", c => c.String());
            AddColumn("dbo.HealthRecords", "Conclusion", c => c.String());
            AddColumn("dbo.HealthRecords", "Dermatology", c => c.String());
            AddColumn("dbo.HealthRecords", "Surgery", c => c.String());
            AddColumn("dbo.HealthRecords", "Neuropsychiatric", c => c.String());
            AddColumn("dbo.HealthRecords", "PathologicalMedical", c => c.String());
            AddColumn("dbo.HealthRecords", "BloodPressure", c => c.Single());
            AddColumn("dbo.HealthRecords", "Circuit", c => c.Single());
            AddColumn("dbo.HealthRecords", "DOL", c => c.String());
            AddColumn("dbo.HealthRecords", "PathologicalENT", c => c.String());
            AddColumn("dbo.HealthRecords", "WhisperRight", c => c.Single());
            AddColumn("dbo.HealthRecords", "WhisperLeft", c => c.Single());
            AddColumn("dbo.HealthRecords", "NormalLeft", c => c.Single());
            AddColumn("dbo.HealthRecords", "NormalRight", c => c.Single());
            AddColumn("dbo.HealthRecords", "PathologicalEyes", c => c.String());
            AddColumn("dbo.HealthRecords", "NoGlassLeft", c => c.String());
            AddColumn("dbo.HealthRecords", "NoGlassRight", c => c.String());
            AddColumn("dbo.HealthRecords", "GlassLeft", c => c.String());
            AddColumn("dbo.HealthRecords", "GlassRight", c => c.String());
            AddColumn("dbo.HealthRecords", "Chest", c => c.Single());
            AddColumn("dbo.HealthRecords", "BMI", c => c.Single());
            AddColumn("dbo.HealthRecords", "Weight", c => c.Single());
            AddColumn("dbo.HealthRecords", "Height", c => c.Single());
            AddColumn("dbo.HealthRecords", "OtherTests", c => c.String());
            AddColumn("dbo.HealthRecords", "ECG", c => c.String());
            AddColumn("dbo.HealthRecords", "StomachSupersonic", c => c.String());
            AddColumn("dbo.HealthRecords", "Xray", c => c.String());
            AddColumn("dbo.HealthRecords", "Immunity", c => c.String());
            AddColumn("dbo.HealthRecords", "Biochemical", c => c.String());
            AddColumn("dbo.HealthRecords", "BloodGroup", c => c.String());
            AddColumn("dbo.HealthRecords", "CBC", c => c.String());
            DropForeignKey("dbo.UrineTests", "SubclinicalID", "dbo.Subclinicals");
            DropForeignKey("dbo.ImmunologicalTests", "SubclinicalID", "dbo.Subclinicals");
            DropForeignKey("dbo.Subclinicals", "HealthRecord_RecordID", "dbo.HealthRecords");
            DropForeignKey("dbo.BloodTests", "SubclinicalID", "dbo.Subclinicals");
            DropForeignKey("dbo.BiochemicalTests", "SubclinicalID", "dbo.Subclinicals");
            DropForeignKey("dbo.Surgeries", "ClinicalID", "dbo.Clinicals");
            DropForeignKey("dbo.PhysicalStrengths", "ClinicalID", "dbo.Clinicals");
            DropForeignKey("dbo.Neurologies", "ClinicalID", "dbo.Clinicals");
            DropForeignKey("dbo.InternalMedicines", "ClinicalID", "dbo.Clinicals");
            DropForeignKey("dbo.Clinicals", "RecordID", "dbo.HealthRecords");
            DropForeignKey("dbo.Eyes", "WithoutGlasses_Id", "dbo.Visions");
            DropForeignKey("dbo.Eyes", "WithGlasses_Id", "dbo.Visions");
            DropForeignKey("dbo.Visions", "ClinicalID", "dbo.Clinicals");
            DropForeignKey("dbo.Eyes", "ClinicalID", "dbo.Clinicals");
            DropForeignKey("dbo.ENTs", "WhisperSpeak_Id", "dbo.Hearings");
            DropForeignKey("dbo.ENTs", "NormalSpeak_Id", "dbo.Hearings");
            DropForeignKey("dbo.Hearings", "ClinicalID", "dbo.Clinicals");
            DropForeignKey("dbo.ENTs", "ClinicalID", "dbo.Clinicals");
            DropForeignKey("dbo.Dermatologies", "ClinicalID", "dbo.Clinicals");
            DropForeignKey("dbo.DentalOrals", "ClinicalID", "dbo.Clinicals");
            DropIndex("dbo.UrineTests", new[] { "SubclinicalID" });
            DropIndex("dbo.ImmunologicalTests", new[] { "SubclinicalID" });
            DropIndex("dbo.BloodTests", new[] { "SubclinicalID" });
            DropIndex("dbo.BiochemicalTests", new[] { "SubclinicalID" });
            DropIndex("dbo.Subclinicals", new[] { "HealthRecord_RecordID" });
            DropIndex("dbo.Surgeries", new[] { "ClinicalID" });
            DropIndex("dbo.PhysicalStrengths", new[] { "ClinicalID" });
            DropIndex("dbo.Neurologies", new[] { "ClinicalID" });
            DropIndex("dbo.InternalMedicines", new[] { "ClinicalID" });
            DropIndex("dbo.Visions", new[] { "ClinicalID" });
            DropIndex("dbo.Eyes", new[] { "WithoutGlasses_Id" });
            DropIndex("dbo.Eyes", new[] { "WithGlasses_Id" });
            DropIndex("dbo.Eyes", new[] { "ClinicalID" });
            DropIndex("dbo.Hearings", new[] { "ClinicalID" });
            DropIndex("dbo.ENTs", new[] { "WhisperSpeak_Id" });
            DropIndex("dbo.ENTs", new[] { "NormalSpeak_Id" });
            DropIndex("dbo.ENTs", new[] { "ClinicalID" });
            DropIndex("dbo.Dermatologies", new[] { "ClinicalID" });
            DropIndex("dbo.DentalOrals", new[] { "ClinicalID" });
            DropIndex("dbo.Clinicals", new[] { "RecordID" });
            DropTable("dbo.UrineTests");
            DropTable("dbo.ImmunologicalTests");
            DropTable("dbo.BloodTests");
            DropTable("dbo.BiochemicalTests");
            DropTable("dbo.Subclinicals");
            DropTable("dbo.Surgeries");
            DropTable("dbo.PhysicalStrengths");
            DropTable("dbo.Neurologies");
            DropTable("dbo.InternalMedicines");
            DropTable("dbo.Visions");
            DropTable("dbo.Eyes");
            DropTable("dbo.Hearings");
            DropTable("dbo.ENTs");
            DropTable("dbo.Dermatologies");
            DropTable("dbo.DentalOrals");
            DropTable("dbo.Clinicals");
        }
    }
}
