namespace DK_NVQS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class updateDB3 : DbMigration
    {
        public override void Up()
        {
            // Handling foreign key and index changes
            DropForeignKey("dbo.Subclinicals", "HealthRecord_RecordID", "dbo.HealthRecords");
            DropIndex("dbo.Subclinicals", new[] { "HealthRecord_RecordID" });
            RenameColumn(table: "dbo.Subclinicals", name: "HealthRecord_RecordID", newName: "RecordID");

            // Drop the existing primary key and the column with identity
            DropPrimaryKey("dbo.CurriculumVitaes");
            DropColumn("dbo.CurriculumVitaes", "QurriculumVitaeID");

            // Add the new identity column and set it as primary key
            AddColumn("dbo.CurriculumVitaes", "CurriculumVitaeID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CurriculumVitaes", "CurriculumVitaeID");

            // Altering other columns as needed
            AlterColumn("dbo.Subclinicals", "RecordID", c => c.Int(nullable: false));
            CreateIndex("dbo.Subclinicals", "RecordID");
            AddForeignKey("dbo.Subclinicals", "RecordID", "dbo.HealthRecords", "RecordID", cascadeDelete: true);
        }

        public override void Down()
        {
            // Handle the reverse operations to restore previous state
            DropForeignKey("dbo.Subclinicals", "RecordID", "dbo.HealthRecords");
            DropIndex("dbo.Subclinicals", new[] { "RecordID" });
            DropPrimaryKey("dbo.CurriculumVitaes");

            // Restore the old identity column and set it as primary key
            AddColumn("dbo.CurriculumVitaes", "QurriculumVitaeID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CurriculumVitaes", "QurriculumVitaeID");
            DropColumn("dbo.CurriculumVitaes", "CurriculumVitaeID");

            // Revert other column changes
            AlterColumn("dbo.Subclinicals", "RecordID", c => c.Int());
            RenameColumn(table: "dbo.Subclinicals", name: "RecordID", newName: "HealthRecord_RecordID");
            CreateIndex("dbo.Subclinicals", "HealthRecord_RecordID");
            AddForeignKey("dbo.Subclinicals", "HealthRecord_RecordID", "dbo.HealthRecords", "RecordID");
        }
    }
}
