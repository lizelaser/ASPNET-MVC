namespace ASPNETIdentity.Migrations
{
    using IdentitySample.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IdentitySample.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(IdentitySample.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (!context.Roles.Any(r => r.Name == "Admin"))
            //Verificar si el rol Admin no existe
            {
                //contexto de datos
                var store = new RoleStore<ApplicationRole>(context);
                //clae de roles
                var manager = new RoleManager<ApplicationRole>(store);
                //creamos nuestro rol
                var role = new ApplicationRole { Name = "Admin" };
                manager.Create(role);

            }
            //Definimos la contraseña
            var Password1 = new PasswordHasher();

            if (!context.Users.Any(u => u.UserName == "Lizeth@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser { UserName = "Lizeth@gmail.com", Email = "Lizeth@gmail.com", PasswordHash = Password1.HashPassword("Scream&shout123asd") };
                manager.Create(user);
                manager.AddToRole(user.Id, "Admin");

            }
            if (!context.Roles.Any(r => r.Name == "Editor"))
            //Verificar si el rol Admin no existe
            {
                //contexto de datos
                var store = new RoleStore<ApplicationRole>(context);
                //clae de roles
                var manager = new RoleManager<ApplicationRole>(store);
                //creamos nuestro rol
                var role = new ApplicationRole { Name = "Editor" };
                manager.Create(role);

            }
            //Definimos la contraseña
            var Password2 = new PasswordHasher();

            if (!context.Users.Any(u => u.UserName == "Gedy@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser { UserName = "Gedy@gmail.com", Email = "Gedy@gmail.com", PasswordHash = Password1.HashPassword("Scream&shout123asd") };
                manager.Create(user);
                manager.AddToRole(user.Id, "Editor");

            }
            if (!context.Roles.Any(r => r.Name == "Usuarios"))
            //Verificar si el rol Admin no existe
            {
                //contexto de datos
                var store = new RoleStore<ApplicationRole>(context);
                //clae de roles
                var manager = new RoleManager<ApplicationRole>(store);
                //creamos nuestro rol
                var role = new ApplicationRole { Name = "Usuarios" };
                manager.Create(role);

            }


            //Definimos la contraseña
            var Password3 = new PasswordHasher();

            if (!context.Users.Any(u => u.UserName == "Noah@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser { UserName = "Noah@gmail.com", Email = "Noah@gmail.com", PasswordHash = Password1.HashPassword("Scream&shout123asd") };
                manager.Create(user);
                manager.AddToRole(user.Id, "Usuarios");

            }


        }
    }
}
