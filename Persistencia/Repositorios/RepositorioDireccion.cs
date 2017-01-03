using System;
using System.Data.Entity;
using EdoUI.Entidades.DTO;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public class RepositorioDireccion : Repositorio<IDireccionCorreoDTO>, IRepositorioDireccion
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

            IDireccionCorreoDTO iDireccion = this.Obtener(pEntidad.Id);
            if (iDireccion == null)
                throw new InvalidOperationException("ya existe la direccion en la bd");

            this.AgregarEntidad(pEntidad);

        }

        public IDireccionCorreoDTO Obtener(int? pId)
        {
            if (pId.HasValue)
                return base.Obtener(direccion => direccion.Id == pId);
            else
                return base.Obtener();
        }

        public IDireccionCorreoDTO Obtener(string pDireccion = null)
        {
            if (string.IsNullOrEmpty(pDireccion))
                return base.Obtener(direccion => direccion.DireccionDeCorreo == pDireccion);
            else
                return base.Obtener();
        }

        public IEnumerable<IDireccionCorreoDTO> ObtenerSegun(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerSegun(direccion => direccion.Id == pId);
            else
                return base.ObtenerSegun();
        }

        public IEnumerable<IDireccionCorreoDTO> ObtenerSegun(string pDireccion = null)
        {
            if (string.IsNullOrEmpty(pDireccion))
                return base.ObtenerSegun(direccion => direccion.DireccionDeCorreo == pDireccion);
            else
                return base.ObtenerSegun();
        }
    }
}
