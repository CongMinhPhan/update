namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePosts : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.tb_Posts", new[] { "CategoryID" });
            CreateIndex("dbo.tb_Posts", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.tb_Posts", new[] { "CategoryId" });
            CreateIndex("dbo.tb_Posts", "CategoryID");
        }
    }
}
