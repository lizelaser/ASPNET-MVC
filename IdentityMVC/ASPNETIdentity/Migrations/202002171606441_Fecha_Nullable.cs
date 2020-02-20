namespace ASPNETIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fecha_Nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "FechaNacimiento", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "FechaNacimiento", c => c.DateTime(nullable: false));
        }
    }
}
