namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaID = c.Int(nullable: false, identity: true),
                        SocialMediaName = c.String(),
                        SocialMediaLink = c.String(),
                    })
                .PrimaryKey(t => t.SocialMediaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
        }
    }
}
