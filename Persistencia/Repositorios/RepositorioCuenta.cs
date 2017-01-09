using System;
using System.Data.Entity;
using EdoUI.Entidades.DTO;
using System.Collections.Generic;

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

            IDireccionCorreo iDireccion = iRepositorioExterno.Obtener(pEntidad.DireccionCorreo.DireccionDeCorreo);
            //de no existir la direccion, se agrega a la base de datos
            if (iDireccion == null)
                iRepositorioExterno.Agregar(iDireccion);

            iDireccion.Cuenta = pEntidad;
            iDireccion.CuentaId = pEntidad.Id;
            pEntidad.DireccionId = iDireccion.Id;

            //cargar el servidor
            //IServidor iServidor = new Servidor();
            //pEntidad.IServidor = iServidor;

            base.AgregarEntidad(pEntidad);
        }

        public ICuenta Obtener(int? pId)
        {
            if (pId.HasValue)
                return base.Obtener(cuenta => cuenta.Id == pId);
            else
                return base.Obtener();
        }

        public ICuenta Obtener(string pNombre = null)
        {
            if (string.IsNullOrEmpty(pNombre))
                return base.Obtener(cuenta => (cuenta as ICuenta).Nombre == pNombre);
            else
                return base.Obtener();
        }

        public IEnumerable<ICuenta> ObtenerSegun(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerSegun(cuenta => cuenta.Id == pId);
            else
                return base.ObtenerSegun();
        }

        public IEnumerable<ICuenta> ObtenerSegun(string pNombre = null)
        {
            if (string.IsNullOrEmpty(pNombre))
                return base.ObtenerSegun(cuenta => (cuenta as ICuenta).Nombre == pNombre);
            else
                return base.ObtenerSegun();
        }
    }
}
