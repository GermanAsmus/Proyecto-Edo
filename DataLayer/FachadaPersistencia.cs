using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class FachadaPersistencia : IFachadaPersistencia
    {
        private IUnitOfWork iUnitOfWork;

        public FachadaPersistencia()
        {
            this.iUnitOfWork = new UnitOfWork();
        }
        public void AgregarCuenta(ICuentaDeUsuario pCuenta)
        {
            this.iUnitOfWork.RepositorioCuenta.Agregar(pCuenta);
        }
        public void EliminarCuenta(ICuentaDeUsuario pCuenta)
        {
            this.iUnitOfWork.RepositorioCuenta.Eliminar(pCuenta);
        }
        public IEnumerable<ICuentaDeUsuario> ObtenerCuentas()
        {
            return this.iUnitOfWork.RepositorioCuenta.ObtenerTodos();
        }
        public ICuentaDeUsuario ObtenerCuentaPorId(int pId)
        {
            return this.iUnitOfWork.RepositorioCuenta.ObtenerUno(c => c.Id == pId);
        }
        public ICuentaDeUsuario ObtenerCuentaPorNombre(string pNombre)
        {
            return this.iUnitOfWork.RepositorioCuenta.ObtenerUno(c => c.Nombre == pNombre);
        }
    }
}
