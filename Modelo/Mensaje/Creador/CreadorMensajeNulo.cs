using System;
using CapaInterfaces.Modelo;
using Modelo.Mensaje.Creador;

namespace Modelo
{
    public class CreadorMensajeNulo : CreadorMensaje
    {
        protected override IMensajeDTO CrearMensaje()
        {
            return new MensajeNuloDTO();
        }
    }
}