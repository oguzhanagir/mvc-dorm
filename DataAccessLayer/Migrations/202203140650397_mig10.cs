namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dorms", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dorms", "Description", c => c.String(maxLength: 600));
        }
    }
}
