namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DireccionCorreo", "CuentaId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DireccionCorreo", "CuentaId");
        }
    }
}
