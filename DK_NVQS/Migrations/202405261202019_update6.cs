namespace DK_NVQS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "Status", c => c.String(defaultValue: "Chờ xét duyệt"));
            AlterColumn("dbo.Registrations", "NumberOfRegisters", c => c.Int(nullable: false, defaultValue: 1));
        }

        public override void Down()
        {
            AlterColumn("dbo.Registrations", "NumberOfRegisters", c => c.Int(nullable: false));
            AlterColumn("dbo.Registrations", "Status", c => c.String());
        }
    }
}
