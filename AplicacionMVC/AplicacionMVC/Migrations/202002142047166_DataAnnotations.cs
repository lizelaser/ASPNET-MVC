namespace AplicacionMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleados", "Nombre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Empleados", "Categoria", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleados", "Categoria", c => c.String());
            AlterColumn("dbo.Empleados", "Nombre", c => c.String());
        }
    }
}
