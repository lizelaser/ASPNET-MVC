namespace AplicacionMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categoria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleados", "Categoria", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleados", "Categoria");
        }
    }
}
