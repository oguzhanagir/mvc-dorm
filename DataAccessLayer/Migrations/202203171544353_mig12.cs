namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "ImagePath");
        }
    }
}
