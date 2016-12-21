using System;
using EdoUI.DTO;
using Dominio.Persistencia.Repositorio;
using Persistencia.Repositorios.CriteriosDeBusqueda;
using System.Data.Entity;

namespace Persistencia.Repositorios
{
    public class RepositorioCuenta : Repositorio<ICuentaDTO>
    {
        private IRepositorioCompleto<IDireccionCorreoDTO> iRepositorioExterno;

        public RepositorioCuenta(IRepositorioCompleto<IDireccionCorreoDTO> pRepositorioExterno, IDbSet<ICuentaDTO> pDbSet) : base(pDbSet)
        {
            this.iRepositorioExterno = pRepositorioExterno;
        }

        public override void Agregar(ICuentaDTO pEntidad)
        {

            #region programacion defensiva
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            if (pEntidad.DireccionCorreo == null)
                throw new ArgumentNullException(nameof(pEntidad.DireccionCorreo));

            if (pEntidad.GetType() == typeof(ICuentaUsuarioDTO))
            {
                var pEntidadCast = pEntidad as ICuentaUsuarioDTO;
                if (string.IsNullOrEmpty(pEntidadCast.Contraseña) || string.IsNullOrEmpty(pEntidadCast.Nombre))
                    throw new NullReferenceException("los atributos contraseña, nombre, no pueden ser nulos o vacíos");
            } 
            #endregion

            IDireccionCorreoDTO iDireccion = iRepositorioExterno.Obtener(direccion => BuscarDireccionDeCorreo.BuscarPorDireccion(direccion, pEntidad.DireccionCorreo.DireccionDeCorreo));
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
    }
}
