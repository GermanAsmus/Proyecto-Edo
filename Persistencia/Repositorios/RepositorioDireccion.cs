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

            IDireccionCorreo iDireccion = this.ObtenerUno(pEntidad.Id);
            if (iDireccion == null)
                throw new InvalidOperationException("ya existe la direccion en la bd");

            this.AgregarEntidad(pEntidad);

        }

        public IDireccionCorreo ObtenerUno(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerUno(direccion => direccion.Id == pId);
            else
                return base.ObtenerUno();
        }

        public IDireccionCorreo ObtenerUno(string pDireccion = null)
        {
            if (string.IsNullOrEmpty(pDireccion))
                return base.ObtenerUno(direccion => direccion.DireccionDeCorreo == pDireccion);
            else
                return base.ObtenerUno();
        }

        public IEnumerable<IDireccionCorreo> ObtenerTodos(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerTodos(direccion => direccion.Id == pId);
            else
                return base.ObtenerTodos();
        }

        public IEnumerable<IDireccionCorreo> ObtenerTodos(string pDireccion = null)
        {
            if (string.IsNullOrEmpty(pDireccion))
                return base.ObtenerTodos(direccion => direccion.DireccionDeCorreo == pDireccion);
            else
                return base.ObtenerTodos();
        }
    }
}
