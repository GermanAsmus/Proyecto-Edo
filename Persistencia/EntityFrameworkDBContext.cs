using System;
using Modelo;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using Persistencia.Excepciones;

namespace Persistencia
{
    public class EntityFrameworkDBContext : DbContext, IContext
    {
        public IDbSet<CuentaDAO> Cuenta { get; set; }
        public IDbSet<MensajeDAO> Mensaje { get; set; }
        //public IDbSet<ServidorDAO> ServidorDAO { get; set; }
        public IDbSet<DireccionCorreo> DireccionCorreo { get; set; }
        public IDbSet<AdjuntoDTO> Adjunto { get; set; }

        public EntityFrameworkDBContext()
            : base("DataBase")
        {
            //Database.SetInitializer<EntityFrameworkDBContext>(null);
            try
            { 
            if (!this.Database.Exists())
                    if (!this.Database.CreateIfNotExists())
                        throw new CreateDatabaseException("Problemas con creación de la base de datos, verifique que tenga instalado sql express");
            }
            catch (Exception sqlException)
            {
                throw new SqlServiceException("Problemas con la conexión a la base de datos, verifique que el servicio SQL Server (SQLEXPRESS) esté incializado", sqlException);
            }

            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.AutoDetectChangesEnabled = true;
        }

        public int Commit()
        {
            string mensaje = "No se pudienron guardar los cambios";
            try
            {
                return base.SaveChanges();
            }
            catch(InvalidOperationException ex)
            {
                throw new InvalidOperationException(mensaje, ex);
            }
            catch(DbUpdateException ex)
            {
                throw new UpdateDatabaseException("No se pudo actualizar la base de datos, "+mensaje, ex);
            }
            catch(DbEntityValidationException ex)
            {
                throw new ValidateDatabaseEntityException("No se pudieron validar las entidades que se pretendían salvar, "+mensaje, ex);
            }

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            ////modelBuilder.Entity<ServidorDAO>().ToTable("ServidorDAO");
            ////modelBuilder.Entity<ServidorDAO>().HasKey<int>(x => x.Id);
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.Nombre).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.HostPOP).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.HostSMTP).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.PuertoPOP).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.PuertoSMTP).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.SSL).IsRequired();

            //modelBuilder.Entity<CuentaDAO>().ToTable("CuentaDAO");
            //modelBuilder.Entity<CuentaDAO>().HasKey<int>(x => x.Id);
            //modelBuilder.Entity<CuentaDAO>().Property(x => x.Nombre).IsRequired();
            //modelBuilder.Entity<CuentaDAO>().Property(x => x.DireccionId).IsRequired();
            //modelBuilder.Entity<CuentaDAO>().Property(x => x.Contraseña).IsRequired();
            ////modelBuilder.Entity<CuentaDAO>().HasRequired(x => x.ServidorDAO).WithMany(y => y.CuentaDAO).HasForeignKey(z => z.ServidorId).WillCascadeOnDelete(false);
            //modelBuilder.Entity<CuentaDAO>().HasRequired(x => x.DireccionCorreo).WithOptional(y => y.CuentaDAO);

            //modelBuilder.Entity<DireccionCorreo>().ToTable("DireccionCorreo");
            //modelBuilder.Entity<DireccionCorreo>().HasKey<int>(x => x.Id);
            //modelBuilder.Entity<DireccionCorreo>().Property(x => x.DireccionDeCorreo).IsRequired();
            //modelBuilder.Entity<DireccionCorreo>().HasMany(x => x.MensajesRemitente).WithRequired(y => y.DireccionCorreo).HasForeignKey(z => z.DireccionId).WillCascadeOnDelete(false);
            //modelBuilder.Entity<DireccionCorreo>().HasMany(x => x.MensajesDestinatario).WithMany(y => y.Destinatario).Map(t => { t.ToTable("DireccionCorreoMensaje"); });

            //modelBuilder.Entity<MensajeDAO>().ToTable("MensajeDAO");
            //modelBuilder.Entity<MensajeDAO>().HasKey<int>(x => x.Id);
            //modelBuilder.Entity<MensajeDAO>().Property(x => x.Asunto).IsRequired();
            //modelBuilder.Entity<MensajeDAO>().Property(x => x.CodigoMensaje).IsOptional();
            //modelBuilder.Entity<MensajeDAO>().Property(x => x.Contenido).IsOptional();
            //modelBuilder.Entity<MensajeDAO>().Property(x => x.Leido).IsOptional();
            //modelBuilder.Entity<MensajeDAO>().Property(x => x.Fecha).IsRequired();
            //modelBuilder.Entity<MensajeDAO>().HasRequired(x => x.CuentaDAO).WithMany(y => y.Mensajes).HasForeignKey(z => z.CuentaId);
            //modelBuilder.Entity<MensajeDAO>().HasMany(x => x.Adjuntos).WithMany(y => y.Mensajes).Map(t => { t.ToTable("AdjuntoMensaje"); });

            //modelBuilder.Entity<AdjuntoDTO>().ToTable("AdjuntoDTO");
            //modelBuilder.Entity<AdjuntoDTO>().HasKey<int>(x => x.Id);
            //modelBuilder.Entity<AdjuntoDTO>().Property(x => x.CodigoAdjunto).IsRequired();
        }
    }
}
