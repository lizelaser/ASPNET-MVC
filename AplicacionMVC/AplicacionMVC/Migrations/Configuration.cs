namespace AplicacionMVC.Migrations
{
    using AplicacionMVC.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AplicacionMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AplicacionMVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Empleados.AddOrUpdate(i => i.Nombre, new Models.Empleados
            {
                Nombre="Lizeth",
                Antiguedad=8,
                Edad=22,
                Categoria="A"
            },
            new Empleados
            {
                Nombre="Gedy",
                Antiguedad=12,
                Edad=23,
                Categoria = "A"
            },
            new Empleados
            {
                Nombre = "Noah",
                Antiguedad = 3,
                Edad = 15,
                Categoria = "A"
            },
            new Empleados
            {
                Nombre = "Finn",
                Antiguedad = 5,
                Edad = 16,
                Categoria = "A"
            },
            new Empleados
            {
                Nombre = "Paola",
                Antiguedad = 20,
                Edad = 30,
                Categoria = "A"
            },
            new Empleados
            {
                Nombre = "Matias",
                Antiguedad = 7,
                Edad = 25,
                Categoria = "A"
            },
            new Empleados
            {
                Nombre = "Joaquin",
                Antiguedad = 15,
                Edad = 25,
                Categoria = "A"
            },
            new Empleados
            {
                Nombre = "Pepe",
                Antiguedad = 14,
                Edad = 23,
                Categoria = "A"
            }


            );
        }
    }
}
