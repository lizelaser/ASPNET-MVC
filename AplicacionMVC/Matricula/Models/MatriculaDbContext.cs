namespace Matricula.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MatriculaDbContext : DbContext
    {
        public MatriculaDbContext()
            : base("name=MatriculaDbContext")
        {
        }

        public virtual DbSet<Alumno> Alumnoes { get; set; }
        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<CajaDiario> CajaDiarios { get; set; }
        public virtual DbSet<CajaMovimiento> CajaMovimientoes { get; set; }
        public virtual DbSet<Curso> Cursoes { get; set; }
        public virtual DbSet<Especialidad> Especialidads { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Matricula> Matriculas { get; set; }
        public virtual DbSet<MatriculaDetalle> MatriculaDetalles { get; set; }
        public virtual DbSet<Periodo> Periodoes { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<PlanPago> PlanPagoes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<ValorTabla> ValorTablas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Materno)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Dni)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.CajaMovimientoes)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Matriculas)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Caja>()
                .Property(e => e.Denominacion)
                .IsUnicode(false);

            modelBuilder.Entity<Caja>()
                .HasMany(e => e.CajaDiarios)
                .WithRequired(e => e.Caja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CajaDiario>()
                .Property(e => e.SaldoInicial)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CajaDiario>()
                .Property(e => e.Entradas)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CajaDiario>()
                .Property(e => e.Salidas)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CajaDiario>()
                .Property(e => e.SaldoFinal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CajaDiario>()
                .HasMany(e => e.CajaMovimientoes)
                .WithRequired(e => e.CajaDiario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CajaMovimiento>()
                .Property(e => e.Operacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CajaMovimiento>()
                .Property(e => e.Importe)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CajaMovimiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.Denominacion)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.Matricula)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Curso>()
                .Property(e => e.Mensualidad)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Horarios)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.MatriculaDetalles)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.Denominacion)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.Matricula)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.Mensualidad)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Especialidad>()
                .HasMany(e => e.Cursoes)
                .WithRequired(e => e.Especialidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matricula>()
                .Property(e => e.Monto)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Matricula>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Matricula>()
                .HasMany(e => e.MatriculaDetalles)
                .WithRequired(e => e.Matricula)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matricula>()
                .HasMany(e => e.PlanPagoes)
                .WithRequired(e => e.Matricula)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatriculaDetalle>()
                .Property(e => e.Nota)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MatriculaDetalle>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Periodo>()
                .Property(e => e.Denominacion)
                .IsUnicode(false);

            modelBuilder.Entity<Periodo>()
                .HasMany(e => e.Horarios)
                .WithRequired(e => e.Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Periodo>()
                .HasMany(e => e.Matriculas)
                .WithRequired(e => e.Periodo)
                .HasForeignKey(e => e.PeridoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Materno)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Dni)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Honorario)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PlanPago>()
                .Property(e => e.Cuota)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Denominacion)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Codigo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.CajaDiarios)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ValorTabla>()
                .Property(e => e.Denominacion)
                .IsUnicode(false);

            modelBuilder.Entity<ValorTabla>()
                .Property(e => e.DesCorta)
                .IsUnicode(false);

            modelBuilder.Entity<ValorTabla>()
                .Property(e => e.Valor)
                .IsUnicode(false);
        }
    }
}
