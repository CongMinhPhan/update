﻿namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductCate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "Alias", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "Icon", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategory", "Icon", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_ProductCategory", "Title", c => c.String());
            DropColumn("dbo.tb_ProductCategory", "Alias");
        }
    }
}
