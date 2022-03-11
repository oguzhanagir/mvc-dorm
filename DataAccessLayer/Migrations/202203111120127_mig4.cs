﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "NewsTitle", c => c.String(maxLength: 50));
            AlterColumn("dbo.News", "NewsLink", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "NewsLink", c => c.String());
            AlterColumn("dbo.News", "NewsTitle", c => c.String());
        }
    }
}
