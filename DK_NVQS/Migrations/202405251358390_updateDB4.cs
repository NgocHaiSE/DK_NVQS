namespace DK_NVQS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDB4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HealthRecords", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HealthRecords", "Date");
        }
    }
}
