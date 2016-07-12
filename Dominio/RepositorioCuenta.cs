using ControlDependencia;
using ControlDependencia.Dominio;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.CriteriosDeBusqueda;
using ControlDependencia.Persistencia;

namespace Dominio
{
    public class RepositorioCuenta : RepositorioAbstracto<Cuenta>, IRepositorioUnico<Cuenta>
    {
        private IRepositorioUnico<DireccionCorreo> iRepositorioExterno;

        public RepositorioCuenta(IRepositorioUnico<Cuenta> pRepositorioInterno, IRepositorioUnico<DireccionCorreo> pRepositorioExterno) : base (pRepositorioInterno) {        }

        public int Agregar(Cuenta pEntidad)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            if (pEntidad.DireccionCorreo == null)
                throw new ArgumentNullException(nameof(pEntidad.DireccionCorreo));

            if (string.IsNullOrEmpty(pEntidad.Contraseña) || string.IsNullOrEmpty(pEntidad.Nombre))
                throw new NullReferenceException("los atributos contraseña, nombre, no pueden ser nulos o vacíos");

            DireccionCorreo iDireccion = iRepositorioExterno.Obtener(direccion => BuscarDireccionDeCorreo.BuscarPorDireccion(direccion, pEntidad.DireccionCorreo.DireccionDeCorreo));
            //de no existir la direccion, se agrega a la base de datos
            if (iDireccion != null)
                throw new Exception();

            iRepositorioExterno.Agregar(pEntidad.DireccionCorreo);
            iDireccion.Cuenta = pEntidad;
            iDireccion.CuentaId = pEntidad.Id;
            pEntidad.DireccionId = iDireccion.Id;

            //cargar el servidor
            Servidor iServidor = new Servidor();
            pEntidad.Servidor = iServidor;

            return iRepositorio.Agregar(pEntidad);
        }
    }
}
