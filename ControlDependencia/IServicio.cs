using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlDependencia
{
    public interface IServicio<T> : IServicioRaiz where T : class
    {
        IRepositorio<T> Repositorio { get; }

        IServicioRaiz Editar(T entidad);
        void Eliminar(Expression<Func<T, bool>> criterio);
        T Obtener(Expression<Func<T, bool>> criterio);
        IEnumerable<T> ObtenerTodos();
        IEnumerable<T> Encontrar(Expression<Func<T, bool>> criterio);
    }
}
