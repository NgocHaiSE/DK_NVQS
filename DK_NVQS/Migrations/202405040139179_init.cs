namespace DK_NVQS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citizens",
                c => new
                    {
                        CitizenID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Gender = c.Boolean(),
                        DateOfBirth = c.DateTime(),
                        Address = c.String(),
                        Hometown = c.String(),
                        Age = c.Int(),
                        Status = c.String(),
                        Eligible = c.Boolean(),
                        Ready = c.Boolean(),
                    })
                .PrimaryKey(t => t.CitizenID);
            
            CreateTable(
                "dbo.HealthRecords",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        CBC = c.String(),
                        BloodGroup = c.String(),
                        Biochemical = c.String(),
                        Immunity = c.String(),
                        Xray = c.String(),
                        StomachSupersonic = c.String(),
                        ECG = c.String(),
                        OtherTests = c.String(),
                        Height = c.Single(),
                        Weight = c.Single(),
                        BMI = c.Single(),
                        Chest = c.Single(),
                        GlassRight = c.String(),
                        GlassLeft = c.String(),
                        NoGlassRight = c.String(),
                        NoGlassLeft = c.String(),
                        PathologicalEyes = c.String(),
                        NormalRight = c.Single(),

                        NormalLeft = c.Single(),
                        WhisperLeft = c.Single(),
                        WhisperRight = c.Single(),
                        PathologicalENT = c.String(),
                        DOL = c.String(),
                        Circuit = c.Single(),
                        BloodPressure = c.Single(),
                        PathologicalMedical = c.String(),
                        Neuropsychiatric = c.String(),
                        Surgery = c.String(),
                        Dermatology = c.String(),
                        Conclusion = c.String(),
                        PhysicalPoint = c.String(),
                        EyePoint = c.String(),
                        ENTPoint = c.String(),
                        DOLPoint = c.String(),
                        MedicalPoint = c.String(),
                        NeuropsychiatricPoint = c.String(),
                        SurgeryPoint = c.String(),
                        DermatologyPoint = c.String(),
                        ConclusionPoint = c.String(),
                        Citizen_CitizenID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.Citizens", t => t.Citizen_CitizenID)
                .Index(t => t.Citizen_CitizenID);
            
            CreateTable(
                "dbo.CurriculumVitaes",
                c => new
                    {
                        QurriculumVitaeID = c.Int(nullable: false, identity: true),
                        CitizenID = c.String(maxLength: 128),
                        PhotoPath = c.String(),
                        JobBefore = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        FatherBornYear = c.Int(),
                        MotherBornYear = c.Int(),
                        FatherJob = c.String(),
                        MotherJob = c.String(),
                        Domicile = c.String(),
                        Residence = c.String(),
                        FamilyAnamnesis = c.String(),
                        SelfAnamnesis = c.String(),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.QurriculumVitaeID)
                .ForeignKey("dbo.Citizens", t => t.CitizenID)
                .Index(t => t.CitizenID);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        RegistrationFormID = c.Int(nullable: false, identity: true),
                        CitizenID = c.String(maxLength: 128),
                        Type = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        NumberOfPostponements = c.Int(nullable: false),
                        NumberOfRegisters = c.Int(nullable: false),
                        NumberOfExemptions = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.RegistrationFormID)
                .ForeignKey("dbo.Citizens", t => t.CitizenID)
                .Index(t => t.CitizenID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registrations", "CitizenID", "dbo.Citizens");
            DropForeignKey("dbo.CurriculumVitaes", "CitizenID", "dbo.Citizens");
            DropForeignKey("dbo.HealthRecords", "Citizen_CitizenID", "dbo.Citizens");
            DropIndex("dbo.Registrations", new[] { "CitizenID" });
            DropIndex("dbo.CurriculumVitaes", new[] { "CitizenID" });
            DropIndex("dbo.HealthRecords", new[] { "Citizen_CitizenID" });
            DropTable("dbo.Registrations");
            DropTable("dbo.CurriculumVitaes");
            DropTable("dbo.HealthRecords");
            DropTable("dbo.Citizens");
        }
    }
}
