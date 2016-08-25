using CapaInterfaces;
using System;
using Utilidades.CriteriosDeBusqueda;
using CapaInterfaces.Modelo;

namespace Dominio.Repositorios
{
    public class RepositorioCuenta : RepositorioAbstracto<ICuenta>, IRepositorioUnico<ICuenta>
    {
        private IRepositorioUnico<IDireccionCorreo> iRepositorioExterno;

        public RepositorioCuenta(IRepositorioUnico<ICuenta> pRepositorioInterno, IRepositorioUnico<IDireccionCorreo> pRepositorioExterno) : base(pRepositorioInterno)
        {
            this.iRepositorioExterno = pRepositorioExterno;
        }

        public int Agregar(ICuenta pEntidad)
        {

            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            if (pEntidad.DireccionCorreo == null)
                throw new ArgumentNullException(nameof(pEntidad.DireccionCorreo));

            if (pEntidad.GetType() == typeof(ICuentaUsuario))
            {
                var pEntidadCast = pEntidad as ICuentaUsuario;
                if (string.IsNullOrEmpty(pEntidadCast.Contraseña) || string.IsNullOrEmpty(pEntidadCast.Nombre))
                    throw new NullReferenceException("los atributos contraseña, nombre, no pueden ser nulos o vacíos");
            }
            IDireccionCorreo iDireccion = iRepositorioExterno.Obtener(direccion => BuscarDireccionDeCorreo.BuscarPorDireccion(direccion, pEntidad.DireccionCorreo.DireccionDeCorreo));
            //de no existir la direccion, se agrega a la base de datos
            if (iDireccion == null)
                iRepositorioExterno.Agregar(iDireccion);

            iDireccion.Cuenta = pEntidad;
            iDireccion.CuentaId = pEntidad.Id;
            pEntidad.DireccionId = iDireccion.Id;

            //cargar el servidor
            //IServidor iServidor = new Servidor();
            //pEntidad.IServidor = iServidor;

            return iRepositorio.Agregar(pEntidad);
        }
    }
}
