namespace ASPNETIdentity.TiendaMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eliminacion_Cascada : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.OrderItem", "OrderId", "dbo.Order");
            DropForeignKey("dbo.OrderItem", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "SupplierId", "dbo.Supplier");
            AddForeignKey("dbo.Order", "CustomerId", "dbo.Customer", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderItem", "OrderId", "dbo.Order", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderItem", "ProductId", "dbo.Product", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Product", "SupplierId", "dbo.Supplier", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.OrderItem", "ProductId", "dbo.Product");
            DropForeignKey("dbo.OrderItem", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            AddForeignKey("dbo.Product", "SupplierId", "dbo.Supplier", "Id");
            AddForeignKey("dbo.OrderItem", "ProductId", "dbo.Product", "Id");
            AddForeignKey("dbo.OrderItem", "OrderId", "dbo.Order", "Id");
            AddForeignKey("dbo.Order", "CustomerId", "dbo.Customer", "Id");
        }
    }
}
