using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ControlDependencia;
using Modelo;
using System.Data.Entity;
using ControlDependencia.Persistencia;

namespace Persistencia
{
    public class UnitOfWork : IUnitOfWork
    {
        private EntityFrameworkDBContext iContext;

        public IRepositorio<Adjunto> RepositorioAdjunto { get; set; }

        public IRepositorio<Cuenta> RepositorioCuenta { get; set; }

        public IRepositorio<DireccionCorreo> RepositorioDireccionCorreo { get; set; }

        public IRepositorio<Mensaje> RepositorioMensaje { get; set; }

        public IRepositorio<Servidor> RepositorioServidor { get; set; }

        public UnitOfWork()
        {
            this.iContext = new EntityFrameworkDBContext();
            this.RepositorioAdjunto = new Repositorio<Adjunto>(iContext);
            this.RepositorioCuenta = new Repositorio<Cuenta>(iContext);
            this.RepositorioDireccionCorreo = new Repositorio<DireccionCorreo>(iContext);
            this.RepositorioMensaje = new Repositorio<Mensaje>(iContext);
            this.RepositorioServidor = new Repositorio<Servidor>(iContext);
        }

        public int Commit()
        {
            return iContext.Commit();
        }

        public void Dispose()
        {
            try
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            catch(ArgumentNullException ex)
            {
                throw new ArgumentNullException("El garbage collector no puede finalizar con el finalizar con la instancia del UnitOfWork porque ya es nula",ex);
            }
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (iContext != null)
                {
                    iContext.Dispose();
                    iContext = null;
                }
            }

        }
    }
}
