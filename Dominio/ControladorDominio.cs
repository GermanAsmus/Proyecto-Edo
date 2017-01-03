using CapaInterfaces;
using Dominio.ServicioCorreo;
using System;
using System.Collections.Generic;
using System.Threading;
using EdoUI.Dominio;
using EdoUI.Entidades.DTO;

namespace Dominio
{
    public class ControladorDominio : IControladorDominio
    {
        public void ActualizarInformacionCuentaDestinatarioSeleccionada(ICuentaDTO pCuenta)
        {
            throw new NotImplementedException();
        }

        public void ActualizarInformacionCuentaSeleccionada(ICuentaUsuarioDTO pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public void CrearCuentaNueva(ICuentaUsuarioDTO pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public IMensajeCompletoDTO CrearMensajeNuevo(IMensajeCompletoDTO pMensajeNuevo)
        {
            throw new NotImplementedException();
        }

        public ICollection<IMensajeDTO> DescargarMenajes(ICuentaUsuarioDTO pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public void EliminarCuentaDestinatarioSeleccionada(ICuentaDTO pCuenta)
        {
            throw new NotImplementedException();
        }

        public void EliminarCuentaSeleccionada(ICuentaUsuarioDTO pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public void EliminarMensajeSeleccionado(IMensajeDTO pMensaje)
        {
            throw new NotImplementedException();
        }

        public void EnviarMensaje(IMensajeCompletoDTO pMensaje)
        {
            throw new NotImplementedException();
        }

        public ICollection<ICuentaUsuarioDTO> ListarCuentas()
        {
            throw new NotImplementedException();
        }

        public ICollection<ICuentaDTO> ListarDestinatariosAsociados(ICuentaUsuarioDTO pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public ICollection<IMensajeDTO> ListarMensajes(ICuentaUsuarioDTO pCuentaUsaurio)
        {
            throw new NotImplementedException();
        }

        public void ReenviarMensajeSeleccionado(IMensajeDTO pMensaje)
        {
            throw new NotImplementedException();
        }

        public ICollection<IMensajeDTO> Sincronizar(ICuentaUsuarioDTO pCuentaUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
