namespace DataObjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewWithData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EntityCategories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.EntityProducts",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Weight = c.String(),
                        UnitPrice = c.Double(nullable: false),
                        UnitsInStock = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.EntityCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.EntityOrders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        RequiredDate = c.DateTime(nullable: false),
                        Freight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.EntityOrderDetails",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ProductName = c.String(),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.ProductId })
                .ForeignKey("dbo.EntityOrders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.EntityOrderDetails", new[] { "OrderId" });
            DropIndex("dbo.EntityProducts", new[] { "CategoryId" });
            DropForeignKey("dbo.EntityOrderDetails", "OrderId", "dbo.EntityOrders");
            DropForeignKey("dbo.EntityProducts", "CategoryId", "dbo.EntityCategories");
            DropTable("dbo.EntityOrderDetails");
            DropTable("dbo.EntityOrders");
            DropTable("dbo.EntityProducts");
            DropTable("dbo.EntityCategories");
        }
    }
}
