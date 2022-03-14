namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dorms", "Type", c => c.String(maxLength: 20));
            AlterColumn("dbo.Dorms", "DormName", c => c.String(maxLength: 200));
            AlterColumn("dbo.Dorms", "Bed", c => c.String(maxLength: 15));
            AlterColumn("dbo.Dorms", "Wifi", c => c.String(maxLength: 15));
            AlterColumn("dbo.Dorms", "Advisior", c => c.String(maxLength: 40));
            AlterColumn("dbo.Dorms", "Description", c => c.String(maxLength: 600));
            AlterColumn("dbo.Dorms", "Adress", c => c.String(maxLength: 600));
            AlterColumn("dbo.Dorms", "Website", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dorms", "Website", c => c.String(maxLength: 50));
            AlterColumn("dbo.Dorms", "Adress", c => c.String(maxLength: 300));
            AlterColumn("dbo.Dorms", "Description", c => c.String(maxLength: 150));
            AlterColumn("dbo.Dorms", "Advisior", c => c.String(maxLength: 30));
            AlterColumn("dbo.Dorms", "Wifi", c => c.String(maxLength: 10));
            AlterColumn("dbo.Dorms", "Bed", c => c.String(maxLength: 5));
            AlterColumn("dbo.Dorms", "DormName", c => c.String(maxLength: 150));
            DropColumn("dbo.Dorms", "Type");
        }
    }
}
