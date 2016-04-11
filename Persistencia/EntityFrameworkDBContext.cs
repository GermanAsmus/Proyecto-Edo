using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.ModelConfiguration.Configuration;


namespace Persistencia
{
    public class EntityFrameworkDBContext : DbContext
    {
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Mensaje> Mensaje { get; set; }
        public DbSet<Servidor> Servidor { get; set; }
        public DbSet<DireccionCorreo> DireccionCorreo { get; set; }
        public DbSet<Adjunto> Adjunto { get; set; }

        public EntityFrameworkDBContext()
            : base("DataBase")
        {

            //Database.SetInitializer<EntityFrameworkDBContext>(null);
            if (!this.Database.Exists())
                this.Database.CreateIfNotExists();

            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.AutoDetectChangesEnabled = true;
        }

        public async Task<int> CommitAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Servidor>().ToTable("Servidor");
            modelBuilder.Entity<Servidor>().HasKey<String>(x => x.Nombre);
            modelBuilder.Entity<Servidor>().Property(x => x.HostPOP).IsRequired();
            modelBuilder.Entity<Servidor>().Property(x => x.HostSMTP).IsRequired();
            modelBuilder.Entity<Servidor>().Property(x => x.PuertoPOP).IsRequired();
            modelBuilder.Entity<Servidor>().Property(x => x.PuertoSMTP).IsRequired();
            modelBuilder.Entity<Servidor>().Property(x => x.SSL).IsRequired();



            modelBuilder.Entity<Cuenta>().ToTable("Cuenta");
            modelBuilder.Entity<Cuenta>().HasKey<String>(x => x.CuentaId);
            modelBuilder.Entity<Cuenta>().Property(x => x.DireccionId).IsRequired();
            modelBuilder.Entity<Cuenta>().Property(x => x.Contraseña).IsRequired();
            modelBuilder.Entity<Cuenta>().HasRequired(x => x.Servidor).WithMany(y => y.Cuenta).HasForeignKey<string>(z => z.ServidorId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Cuenta>().HasRequired(x => x.DireccionCorreo).WithOptional(y => y.Cuenta);

            modelBuilder.Entity<DireccionCorreo>().ToTable("DireccionCorreo");
            modelBuilder.Entity<DireccionCorreo>().HasKey<String>(x => x.DireccionId);
            modelBuilder.Entity<DireccionCorreo>().HasMany(x => x.MensajesRemitente).WithRequired(y => y.DireccionCorreo).HasForeignKey(z => z.Remitente).WillCascadeOnDelete(false);
            modelBuilder.Entity<DireccionCorreo>().HasMany(x => x.MensajesDestinatario).WithMany(y => y.Destinatario).Map(t => { t.ToTable("DireccionCorreoMensaje"); });

            modelBuilder.Entity<Mensaje>().HasKey<string>(x => x.MensajeId);
            modelBuilder.Entity<Mensaje>().Property(x => x.MensajeId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            modelBuilder.Entity<Mensaje>().HasRequired(x => x.Cuenta).WithMany(y => y.Mensajes).HasForeignKey(z => z.CuentaId);
            //modelBuilder.Entity<Mensaje>().HasRequired(x => x.Remitente).WithOptional();
            modelBuilder.Entity<Completo>().HasMany(x => x.Adjuntos).WithMany(y => y.Mensajes).Map(t => { t.ToTable("AdjuntoMensaje"); });
            modelBuilder.Entity<Completo>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Mensaje");

            });

            modelBuilder.Entity<Adjunto>().ToTable("Adjunto");
            modelBuilder.Entity<Adjunto>().HasKey<String>(x => x.AdjuntoId);





        }
    }
}
