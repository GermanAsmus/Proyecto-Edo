using System.Collections.Generic;

namespace CapaInterfaces.Persistencia
{
    /// <summary>
    /// Unidad de trabajo, mantiene el contexto de ejecución.
    /// </summary>
    public interface IUnitOfWork
    {
        IContext Context { get; set; }
        ICollection<IRepositorioRaiz> Repositorios { get; }
        IRepositorioUnico<T> ObtenerRepositorio<T>() where T : class;
        int Commit();
    }
}
