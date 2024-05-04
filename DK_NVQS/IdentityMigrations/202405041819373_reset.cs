namespace DK_NVQS.IdentityMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reset : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CitizenID", c => c.String());
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "Hometown", c => c.String());
            DropColumn("dbo.AspNetUsers", "BirthDay");
            DropColumn("dbo.AspNetUsers", "City");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "BirthDay", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "Hometown");
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "Name");
            DropColumn("dbo.AspNetUsers", "CitizenID");
        }
    }
}
