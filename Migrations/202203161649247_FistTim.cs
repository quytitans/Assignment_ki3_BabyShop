namespace AssignmentWCD_BabyFashionShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FistTim : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clothes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Thumnail = c.String(),
                        Price = c.Double(nullable: false),
                        Color = c.String(),
                        Status = c.Int(nullable: false),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clothes", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Clothes", new[] { "CategoryId" });
            DropTable("dbo.Clothes");
            DropTable("dbo.Categories");
        }
    }
}
