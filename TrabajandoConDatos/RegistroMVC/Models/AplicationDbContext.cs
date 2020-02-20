namespace RegistroMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AplicationDbContext : DbContext
    {
        public AplicationDbContext()
            : base("name=AplicationDbContext")
        {
        }

        public virtual DbSet<Registro> Registro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registro>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Registro>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Registro>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Registro>()
                .Property(e => e.Contrasena)
                .IsUnicode(false);
        }
    }
}
