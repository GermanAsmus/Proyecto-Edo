using System;
using System.Data.Entity;
using System.Collections.Generic;
using Dominio.Entidades.Interfaces;

namespace Persistencia.Repositorios
{
    public class RepositorioCuenta : Repositorio<ICuenta>, IRepositorioCuenta
    {
        private IRepositorioDireccion iRepositorioExterno;

        public RepositorioCuenta(IRepositorioDireccion pRepositorioExterno, IDbSet<ICuenta> pDbSet) : base(pDbSet)
        {
            this.iRepositorioExterno = pRepositorioExterno;
        }

        public override void Agregar(ICuenta pEntidad)
        {

            #region programacion defensiva
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            if (pEntidad.DireccionCorreo == null)
                throw new ArgumentNullException(nameof(pEntidad.DireccionCorreo));

            if (pEntidad.GetType() == typeof(ICuenta))
            {
                var pEntidadCast = pEntidad as ICuenta;
                if (string.IsNullOrEmpty(pEntidadCast.Contraseña) || string.IsNullOrEmpty(pEntidadCast.Nombre))
                    throw new NullReferenceException("los atributos contraseña, nombre, no pueden ser nulos o vacíos");
            } 
            #endregion

            IDireccionCorreo iDireccion = iRepositorioExterno.ObtenerUno(pEntidad.DireccionCorreo.DireccionDeCorreo);
            //de no existir la direccion, se agrega a la base de datos
            if (iDireccion == null)
                iRepositorioExterno.Agregar(iDireccion);

            base.AgregarEntidad(pEntidad);
        }

        public ICuenta ObtenerUno(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerUno(cuenta => cuenta.Id == pId);
            else
                return base.ObtenerUno();
        }

        public ICuenta ObtenerUno(string pNombre = null)
        {
            if (string.IsNullOrEmpty(pNombre))
                return base.ObtenerUno(cuenta => (cuenta as ICuenta).Nombre == pNombre);
            else
                return base.ObtenerUno();
        }

        public IEnumerable<ICuenta> ObtenerTodos(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerTodos(cuenta => cuenta.Id == pId);
            else
                return base.ObtenerTodos();
        }

        public IEnumerable<ICuenta> ObtenerTodos(string pNombre = null)
        {
            if (string.IsNullOrEmpty(pNombre))
                return base.ObtenerTodos(cuenta => (cuenta as ICuenta).Nombre == pNombre);
            else
                return base.ObtenerTodos();
        }
    }
}
