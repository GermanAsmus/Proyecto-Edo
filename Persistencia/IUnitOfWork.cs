using Dominio.Entidades.Interfaces;
using Persistencia.Repositorios;

namespace Persistencia
{
    public interface IUnitOfWork
    {
        IRepositorioCompleto<T> ObtenerRepositorio<T>() where T : class, IEntidadModelo;

        int Commit();
        void Dispose();
    }
}