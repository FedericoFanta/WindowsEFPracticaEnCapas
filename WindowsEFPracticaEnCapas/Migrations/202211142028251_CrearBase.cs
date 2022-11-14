namespace WindowsEFPracticaEnCapas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clasificacions",
                c => new
                    {
                        ClasificacionId = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ClasificacionId);
            
            CreateTable(
                "dbo.Peliculas",
                c => new
                    {
                        PeliculaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        ClasificacionId = c.Int(nullable: false),
                        FechaEstreno = c.DateTime(nullable: false),
                        CantidadMinutos = c.Int(nullable: false),
                        GeneroId = c.String(),
                        Idioma = c.String(),
                        Sinopsis = c.String(),
                        Genero_GeneroId = c.Int(),
                    })
                .PrimaryKey(t => t.PeliculaId)
                .ForeignKey("dbo.Clasificacions", t => t.ClasificacionId, cascadeDelete: true)
                .ForeignKey("dbo.Generoes", t => t.Genero_GeneroId)
                .Index(t => t.ClasificacionId)
                .Index(t => t.Genero_GeneroId);
            
            CreateTable(
                "dbo.Generoes",
                c => new
                    {
                        GeneroId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.GeneroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Peliculas", "Genero_GeneroId", "dbo.Generoes");
            DropForeignKey("dbo.Peliculas", "ClasificacionId", "dbo.Clasificacions");
            DropIndex("dbo.Peliculas", new[] { "Genero_GeneroId" });
            DropIndex("dbo.Peliculas", new[] { "ClasificacionId" });
            DropTable("dbo.Generoes");
            DropTable("dbo.Peliculas");
            DropTable("dbo.Clasificacions");
        }
    }
}
