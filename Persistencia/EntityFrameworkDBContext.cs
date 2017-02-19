using System;
using System.Linq;
using Dominio.Entidades;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using Persistencia.Excepciones;

namespace Persistencia
{
    public class EntityFrameworkDBContext : DbContext, IContext
    {
        public IDbSet<Cuenta> Cuentas { get; set; }
        public IDbSet<Mensaje> Mensajes { get; set; }
        //public IDbSet<ServidorDAO> ServidorDAO { get; set; }
        public IDbSet<DireccionCorreo> DireccionesCorreo { get; set; }
        //public IDbSet<Adjunto> Adjuntos { get; set; }

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

            #region old
            ////modelBuilder.Entity<ServidorDAO>().ToTable("ServidorDAO");
            ////modelBuilder.Entity<ServidorDAO>().HasKey<int>(x => x.Id);
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.Tipo).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.HostPOP).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.HostSMTP).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.PuertoPOP).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.PuertoSMTP).IsRequired();
            ////modelBuilder.Entity<ServidorDAO>().Property(x => x.SSL).IsRequired(); 
            #endregion

            modelBuilder.Entity<Cuenta>().ToTable("Cuentas");
            modelBuilder.Entity<Cuenta>().HasKey<int>(x => x.Id);
            modelBuilder.Entity<Cuenta>().Property(x => x.DireccionId).IsRequired();
            //modelBuilder.Entity<ICuenta>().HasRequired(x => x.ServidorDAO).WithMany(y => y.ICuenta).HasForeignKey(z => z.ServidorId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Cuenta>().HasRequired(x => x.DireccionCorreo).WithOptional();

            modelBuilder.Entity<DireccionCorreo>().ToTable("DireccionesDeCorreo");
            modelBuilder.Entity<DireccionCorreo>().HasKey<int>(x => x.Id);
            modelBuilder.Entity<DireccionCorreo>().Property(x => x.DireccionDeCorreo).IsRequired();
            modelBuilder.Entity<DireccionCorreo>().HasMany(x => x.MensajesRemitente).WithRequired().HasForeignKey(z => z.Cuenta.DireccionCorreo).WillCascadeOnDelete(false);
            modelBuilder.Entity<DireccionCorreo>().HasMany(x => x.MensajesDestinatario).WithMany();
                //(y => y.Destinatario.Select(d => d.DireccionCorreo)).Map(t => { t.ToTable("DireccionDeCorreoMensaje"); });

            modelBuilder.Entity<Mensaje>().ToTable("Mensajes");
            modelBuilder.Entity<Mensaje>().HasKey<int>(x => x.Id);
            modelBuilder.Entity<Mensaje>().Property(x => x.Asunto).IsRequired();
            modelBuilder.Entity<Mensaje>().Property(x => x.Contenido).IsOptional();
                modelBuilder.Entity<Mensaje>().Property(x => x.EstadoEnviado).IsOptional();
                modelBuilder.Entity<Mensaje>().Property(x => x.EstadoGuardado).IsOptional();
                modelBuilder.Entity<Mensaje>().Property(x => x.EstadoVisto).IsOptional();
            modelBuilder.Entity<Mensaje>().HasRequired(x => x.Cuenta).WithMany().HasForeignKey(z => z.CuentaId);
            //modelBuilder.Entity<Mensaje>().HasMany(x => x.Adjuntos).WithMany().Map(t => { t.ToTable("AdjuntosMensajes"); });

            //modelBuilder.Entity<Adjunto>().ToTable("Adjuntos");
            //modelBuilder.Entity<Adjunto>().HasKey<int>(x => x.Id);
            //modelBuilder.Entity<Adjunto>().Property(x => x.PathAdjunto).IsRequired();
        }
    }
}
