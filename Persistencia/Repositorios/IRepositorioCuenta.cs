using Dominio.Entidades.Interfaces;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioCuenta : IRepositorioCompleto<ICuenta>
    {
        ICuenta ObtenerUno(int? pId);

        ICuenta ObtenerUno(string pNombre = null);

        IEnumerable<ICuenta> ObtenerTodos(int? pId);

        IEnumerable<ICuenta> ObtenerTodos(string pNombre = null);
    }
}