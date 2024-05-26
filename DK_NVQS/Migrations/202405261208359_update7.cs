namespace DK_NVQS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Registrations", "NumberOfPostponements");
            DropColumn("dbo.Registrations", "NumberOfExemptions");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registrations", "NumberOfExemptions", c => c.Int(nullable: false));
            AddColumn("dbo.Registrations", "NumberOfPostponements", c => c.Int(nullable: false));
        }
    }
}
