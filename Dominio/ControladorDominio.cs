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
        public void ActualizarInformacionCuentaDestinatarioSeleccionada(ICuenta pCuenta)
        {
            throw new NotImplementedException();
        }

        public void ActualizarInformacionCuentaSeleccionada(ICuenta pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public void CrearCuentaNueva(ICuenta pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public IMensaje CrearMensajeNuevo(IMensaje pMensajeNuevo)
        {
            throw new NotImplementedException();
        }

        public ICollection<IMensaje> DescargarMenajes(ICuenta pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public void EliminarCuentaDestinatarioSeleccionada(ICuenta pCuenta)
        {
            throw new NotImplementedException();
        }

        public void EliminarCuentaSeleccionada(ICuenta pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public void EliminarMensajeSeleccionado(IMensaje pMensaje)
        {
            throw new NotImplementedException();
        }

        public void EnviarMensaje(IMensaje pMensaje)
        {
            throw new NotImplementedException();
        }

        public ICollection<ICuenta> ListarCuentas()
        {
            throw new NotImplementedException();
        }

        public ICollection<ICuenta> ListarDestinatariosAsociados(ICuenta pCuentaUsuario)
        {
            throw new NotImplementedException();
        }

        public ICollection<IMensaje> ListarMensajes(ICuenta pCuentaUsaurio)
        {
            throw new NotImplementedException();
        }

        public void ReenviarMensajeSeleccionado(IMensaje pMensaje)
        {
            throw new NotImplementedException();
        }

        public ICollection<IMensaje> Sincronizar(ICuenta pCuentaUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
