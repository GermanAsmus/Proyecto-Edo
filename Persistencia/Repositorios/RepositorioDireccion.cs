using System;
using System.Data.Entity;
using System.Collections.Generic;
using Dominio.Entidades.Interfaces;

namespace Persistencia.Repositorios
{
    public class RepositorioDireccion : Repositorio<IDireccionCorreo>, IRepositorioDireccion
    {
        public RepositorioDireccion(IDbSet<IDireccionCorreo> pDbSet) : base(pDbSet)
        {

        }

        public override void Agregar(IDireccionCorreo pEntidad)
        {
            #region programacion defensiva
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad)); 
            #endregion

            IDireccionCorreo iDireccion = this.Obtener(pEntidad.Id);
            if (iDireccion == null)
                throw new InvalidOperationException("ya existe la direccion en la bd");

            this.AgregarEntidad(pEntidad);

        }

        public IDireccionCorreo Obtener(int? pId)
        {
            if (pId.HasValue)
                return base.Obtener(direccion => direccion.Id == pId);
            else
                return base.Obtener();
        }

        public IDireccionCorreo Obtener(string pDireccion = null)
        {
            if (string.IsNullOrEmpty(pDireccion))
                return base.Obtener(direccion => direccion.DireccionDeCorreo == pDireccion);
            else
                return base.Obtener();
        }

        public IEnumerable<IDireccionCorreo> ObtenerSegun(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerSegun(direccion => direccion.Id == pId);
            else
                return base.ObtenerSegun();
        }

        public IEnumerable<IDireccionCorreo> ObtenerSegun(string pDireccion = null)
        {
            if (string.IsNullOrEmpty(pDireccion))
                return base.ObtenerSegun(direccion => direccion.DireccionDeCorreo == pDireccion);
            else
                return base.ObtenerSegun();
        }
    }
}
