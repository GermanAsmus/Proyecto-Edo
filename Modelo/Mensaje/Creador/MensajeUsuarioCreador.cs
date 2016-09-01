using System;
using CapaInterfaces.Modelo;
using Modelo.Mensaje.Creador;

namespace Modelo
{
    public class MensajeUsuarioCreador : CreadorMensaje
    {
        protected override IMensajeDTO CrearMensaje()
        {
            IMensajeFactory factoryMensaje = new MensajeUsuarioFactory();
            return new MensajeUsuario(factoryMensaje).MensajeDTO;
        }
    }
}