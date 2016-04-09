using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ControlDependencia;
using Modelo;
using System.Data.Entity;

namespace Persistencia
{
    public class UnitOfWork : IUnitOfWork
    {
        private EntityFrameworkDBContext iContext;

        public IRepositorio<Adjunto> RepositorioAdjunto { get; set; }

        public IRepositorio<Cuenta> RepositorioCuenta { get; set; }

        public IRepositorio<DireccionCorreo> RepositorioDireccionCorreo { get; set; }

        public IRepositorio<Completo> RepositorioMensaje { get; set; }

        public IRepositorio<Servidor> RepositorioServidor { get; set; }

        public UnitOfWork()
        {
            iContext = new EntityFrameworkDBContext();
        }

        public async Task<int> CommitAsync(CancellationToken token)
        {
            return await iContext.CommitAsync();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
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
