namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_News", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_News", "IsActive", c => c.String());
        }
    }
}
