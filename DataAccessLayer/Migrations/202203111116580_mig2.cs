namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dorms", "Wifi", c => c.String(maxLength: 10));
            AlterColumn("dbo.Dorms", "Meal", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dorms", "Meal", c => c.String(maxLength: 1));
            AlterColumn("dbo.Dorms", "Wifi", c => c.String(maxLength: 1));
        }
    }
}
