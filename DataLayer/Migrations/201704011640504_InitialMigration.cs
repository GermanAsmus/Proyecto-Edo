namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cuentas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DireccionDeCorreoId = c.Byte(nullable: false),
                        Contraseña = c.String(),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DireccionesDeCorreo",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DireccionDeCorreo = c.String(nullable: false),
                        CuentaDeUsuarioId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cuentas", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Mensajes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Asunto = c.String(nullable: false),
                        RemitenteId = c.Byte(nullable: false),
                        Contenido = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DireccionesDeCorreo", t => t.RemitenteId, cascadeDelete: true)
                .Index(t => t.RemitenteId);
            
            CreateTable(
                "dbo.DireccionCorreoMensaje",
                c => new
                    {
                        DireccionCorreo_Id = c.Byte(nullable: false),
                        Mensaje_Id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.DireccionCorreo_Id, t.Mensaje_Id })
                .ForeignKey("dbo.DireccionesDeCorreo", t => t.DireccionCorreo_Id, cascadeDelete: true)
                .ForeignKey("dbo.Mensajes", t => t.Mensaje_Id, cascadeDelete: true)
                .Index(t => t.DireccionCorreo_Id)
                .Index(t => t.Mensaje_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DireccionesDeCorreo", "Id", "dbo.Cuentas");
            DropForeignKey("dbo.DireccionCorreoMensaje", "Mensaje_Id", "dbo.Mensajes");
            DropForeignKey("dbo.DireccionCorreoMensaje", "DireccionCorreo_Id", "dbo.DireccionesDeCorreo");
            DropForeignKey("dbo.Mensajes", "RemitenteId", "dbo.DireccionesDeCorreo");
            DropIndex("dbo.DireccionCorreoMensaje", new[] { "Mensaje_Id" });
            DropIndex("dbo.DireccionCorreoMensaje", new[] { "DireccionCorreo_Id" });
            DropIndex("dbo.Mensajes", new[] { "RemitenteId" });
            DropIndex("dbo.DireccionesDeCorreo", new[] { "Id" });
            DropTable("dbo.DireccionCorreoMensaje");
            DropTable("dbo.Mensajes");
            DropTable("dbo.DireccionesDeCorreo");
            DropTable("dbo.Cuentas");
        }
    }
}
