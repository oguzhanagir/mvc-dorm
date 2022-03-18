namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mi12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        DormID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImageID)
                .ForeignKey("dbo.Dorms", t => t.DormID, cascadeDelete: true)
                .Index(t => t.DormID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "DormID", "dbo.Dorms");
            DropIndex("dbo.Images", new[] { "DormID" });
            DropTable("dbo.Images");
        }
    }
}
