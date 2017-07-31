namespace SalesApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newSalesOrderDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.SoHeads",
                c => new
                    {
                        SoHeadId = c.Int(nullable: false, identity: true),
                        SalesOrderTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.SoHeadId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.SoItems",
                c => new
                    {
                        SoItemId = c.Int(nullable: false, identity: true),
                        SequenceNumber = c.Short(nullable: false),
                        ModelNumber = c.String(),
                        ItemTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        SoHead_SoHeadId = c.Int(),
                    })
                .PrimaryKey(t => t.SoItemId)
                .ForeignKey("dbo.SoHeads", t => t.SoHead_SoHeadId)
                .Index(t => t.SoHead_SoHeadId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoItems", "SoHead_SoHeadId", "dbo.SoHeads");
            DropForeignKey("dbo.SoHeads", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.SoItems", new[] { "SoHead_SoHeadId" });
            DropIndex("dbo.SoHeads", new[] { "Customer_CustomerId" });
            DropTable("dbo.SoItems");
            DropTable("dbo.SoHeads");
            DropTable("dbo.Customers");
        }
    }
}
