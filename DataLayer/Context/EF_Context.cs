using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Dominio;

namespace DataLayer
{
    public class EF_Context : DbContext
    {
        public IDbSet<CuentaDeUsuario> Cuentas { get; set; }

        public EF_Context()
            : base("DataBase")
        {
            Database.SetInitializer<EF_Context>(new DropCreateDatabaseIfModelChanges<EF_Context>());
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<CuentaDeUsuario>().ToTable("Cuentas");
            modelBuilder.Entity<CuentaDeUsuario>().HasKey<int>(x => x.Id);
            modelBuilder.Entity<CuentaDeUsuario>().Property(x => x.DireccionId).IsRequired();
            //modelBuilder.Entity<ICuenta>().HasRequired(x => x.ServidorDAO).WithMany(y => y.ICuenta).HasForeignKey(z => z.ServidorId).WillCascadeOnDelete(false);
            modelBuilder.Entity<CuentaDeUsuario>().HasRequired(x => x.DireccionDeCorreo).WithOptional();

            modelBuilder.Entity<DireccionCorreo>().ToTable("DireccionesDeCorreo");
            modelBuilder.Entity<DireccionCorreo>().HasKey<int>(x => x.Id);
            modelBuilder.Entity<DireccionCorreo>().Property(x => x.DireccionDeCorreo).IsRequired();
            modelBuilder.Entity<DireccionCorreo>().HasMany(x => x.MensajesRemitente).WithRequired().HasForeignKey(z => z.RemitenteId).WillCascadeOnDelete(false);
            modelBuilder.Entity<DireccionCorreo>().HasMany(x => x.MensajesDestinatario).WithMany();
            //(y => y.Destinatario.Select(d => d.DireccionCorreo)).Map(t => { t.ToTable("DireccionDeCorreoMensaje"); });

            modelBuilder.Entity<Mensaje>().ToTable("Mensajes");
            modelBuilder.Entity<Mensaje>().HasKey<int>(x => x.Id);
            modelBuilder.Entity<Mensaje>().Property(x => x.Asunto).IsRequired();
            modelBuilder.Entity<Mensaje>().Property(x => x.Contenido).IsOptional();
            modelBuilder.Entity<Mensaje>().HasRequired(x => x.Remitente).WithMany().HasForeignKey(z => z.RemitenteId);
        }
    }
}
