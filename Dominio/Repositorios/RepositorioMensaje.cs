using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaInterfaces.Dominio;
using CapaInterfaces;
using Utilidades.CriteriosDeBusqueda;
using CapaInterfaces.Modelo;

namespace Dominio.Repositorios
{
    public class RepositorioMensaje : RepositorioAbstracto<IMensajeDTO>, IRepositorioCompleto<IMensajeDTO>
    {
        //private IRepositorioCompleto<Adjunto> iRepositorioAdjunto;
        private IRepositorioCompleto<IDireccionCorreoDTO> iRepositorioDireccionDeCorreo;
        private IRepositorioCompleto<ICuentaDTO> iRepositorioCuenta;

        public RepositorioMensaje(IRepositorioCompleto<IMensajeDTO> pRepositorioInterno, /*IRepositorioCompleto<Adjunto> pRepositorioAdjunto,*/ IRepositorioCompleto<IDireccionCorreoDTO> pRepositorioDireccionDeCorreo, IRepositorioCompleto<ICuentaDTO> pRepositorioCuenta) : base(pRepositorioInterno)
        {
            //this.iRepositorioAdjunto = pRepositorioAdjunto;
            this.iRepositorioDireccionDeCorreo = pRepositorioDireccionDeCorreo;
            this.iRepositorioCuenta = pRepositorioCuenta;
        }

        public int Agregar(IMensajeDTO pEntidad)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            if (pEntidad.Cuenta == null)
                throw new ArgumentNullException(nameof(pEntidad.Cuenta));

            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(pEntidad.Asunto))
                throw new NullReferenceException("El asunto del mensaje no puede ser vacío o nulo");

            List<IDireccionCorreoDTO> destinatariosValidos = new List<IDireccionCorreoDTO>();
            var destinatarios = pEntidad.Destinatario.GetEnumerator();

            IDireccionCorreoDTO iDireccion = null;
            while (destinatarios.MoveNext())
            {
                iDireccion = this.iRepositorioDireccionDeCorreo.Obtener(d => BuscarDireccionDeCorreo.BuscarPorDireccion(d, destinatarios.Current.DireccionDeCorreo));
                if (iDireccion != null)
                    destinatariosValidos.Add(destinatarios.Current);
            }
            pEntidad.Destinatario = destinatariosValidos;
                    
            ICuentaUsuarioDTO iCuenta = (ICuentaUsuarioDTO)this.iRepositorioCuenta.Obtener(x => BuscarCuenta.BuscarPorId(x, pEntidad.Cuenta.Id));
            if (iCuenta == null)
                throw new NullReferenceException(nameof(iCuenta));

            iCuenta.Mensajes.Add(pEntidad);
            //Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
            pEntidad.CuentaId = iCuenta.Id;
            //Se actualiza la cuenta, que mantiene una colección de mensajes.
            return iRepositorioCuenta.Actualizar();
        }
    }
}
