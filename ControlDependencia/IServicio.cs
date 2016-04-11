using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ControlDependencia
{
    public interface IServicio<T> : IServicioRaiz where T : class
    {
        IRepositorio<T> Repositorio { get; }

        Task<int> Editar(T entidad);
        Task Eliminar(Expression<Func<T, bool>> criterio);
        Task<T> Obtener(Expression<Func<T, bool>> criterio);
        Task<IEnumerable<T>> ObtenerTodos();
        Task<IEnumerable<T>> Encontrar(Expression<Func<T, bool>> criterio);
    }
}
