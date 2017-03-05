using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IFachadaPersistencia
    {
        void AgregarCuenta(ICuentaDeUsuario pCuenta);
        void EliminarCuenta(ICuentaDeUsuario pCuenta);
        IEnumerable<ICuentaDeUsuario> ObtenerCuentas();
        ICuentaDeUsuario ObtenerCuentaPorId(int pId);
        ICuentaDeUsuario ObtenerCuentaPorNombre(string pNombre);
    }
}
