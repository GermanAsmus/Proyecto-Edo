using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ControlDependencia
{
    public interface IUnitOfWork
    {
        IRepositorio<Cuenta> RepositorioCuenta { get; set; }
        IRepositorio<Completo> RepositorioMensaje { get; set; }
        IRepositorio<Servidor> RepositorioServidor { get; set; }
        IRepositorio<DireccionCorreo> RepositorioDireccionCorreo { get; set; }
        IRepositorio<Adjunto> RepositorioAdjunto { get; set; }

        Task<int> CommitAsync(CancellationToken token);
    }
}
