namespace ASPNETCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SegundaMigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnos",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Apellido = c.String(),
                        Nombre = c.String(nullable: false),
                        FechaMatricula = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoId);
            
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        MatriculaId = c.Int(nullable: false, identity: true),
                        CursoId = c.Int(nullable: false),
                        AlumnoId = c.Int(nullable: false),
                        Precio = c.Int(nullable: false),
                        AnteriorCurso_CursoId = c.Int(),
                        SiguienteCurso_CursoId = c.Int(),
                    })
                .PrimaryKey(t => t.MatriculaId)
                .ForeignKey("dbo.Alumnos", t => t.AlumnoId, cascadeDelete: true)
                .ForeignKey("dbo.Cursos", t => t.AnteriorCurso_CursoId)
                .ForeignKey("dbo.Cursos", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Cursos", t => t.SiguienteCurso_CursoId)
                .Index(t => t.CursoId)
                .Index(t => t.AlumnoId)
                .Index(t => t.AnteriorCurso_CursoId)
                .Index(t => t.SiguienteCurso_CursoId);
            
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Titulo = c.String(maxLength: 24),
                        Creditos = c.Int(nullable: false),
                        TStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.CursoId)
                .Index(t => t.Creditos);
            
            CreateTable(
                "dbo.LicenciaConducir",
                c => new
                    {
                        NumeroLicencia = c.Int(nullable: false),
                        Pais = c.String(nullable: false, maxLength: 128),
                        Expedido = c.DateTime(nullable: false),
                        Caduca = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.NumeroLicencia, t.Pais });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "SiguienteCurso_CursoId", "dbo.Cursos");
            DropForeignKey("dbo.Matriculas", "CursoId", "dbo.Cursos");
            DropForeignKey("dbo.Matriculas", "AnteriorCurso_CursoId", "dbo.Cursos");
            DropForeignKey("dbo.Matriculas", "AlumnoId", "dbo.Alumnos");
            DropIndex("dbo.Cursos", new[] { "Creditos" });
            DropIndex("dbo.Matriculas", new[] { "SiguienteCurso_CursoId" });
            DropIndex("dbo.Matriculas", new[] { "AnteriorCurso_CursoId" });
            DropIndex("dbo.Matriculas", new[] { "AlumnoId" });
            DropIndex("dbo.Matriculas", new[] { "CursoId" });
            DropTable("dbo.LicenciaConducir");
            DropTable("dbo.Cursos");
            DropTable("dbo.Matriculas");
            DropTable("dbo.Alumnos");
        }
    }
}
