namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dorms", "DormImage", c => c.String());
            AlterColumn("dbo.Abouts", "AboutContent", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "AboutContent", c => c.String(maxLength: 500));
            DropColumn("dbo.Dorms", "DormImage");
        }
    }
}
