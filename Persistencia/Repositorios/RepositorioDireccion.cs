using EdoUI.DTO;
using System;
using System.Data.Entity;
using Persistencia.Repositorios.CriteriosDeBusqueda;

namespace Persistencia.Repositorios
{
    public class RepositorioDireccion : Repositorio<IDireccionCorreoDTO>
    {
        public RepositorioDireccion(IDbSet<IDireccionCorreoDTO> pDbSet) : base(pDbSet)
        {

        }

        public override void Agregar(IDireccionCorreoDTO pEntidad)
        {
            #region programacion defensiva
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad)); 
            #endregion

            IDireccionCorreoDTO iDireccion = this.Obtener(x => BuscarDireccionDeCorreo.BuscarPorId(x, pEntidad.Id));
            if (iDireccion == null)
                throw new InvalidOperationException("ya existe la direccion en la bd");

            this.AgregarEntidad(pEntidad);

        }
    }
}
