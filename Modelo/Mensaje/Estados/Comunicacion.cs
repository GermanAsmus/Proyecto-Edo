using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Comunicacion : IEstadoMensaje
    {
        private EstadoComunicacion iEstado;

        public Comunicacion()
        {
            this.iEstado = EstadoComunicacion.No_Enviado;
        }
        public Comunicacion(EstadoComunicacion pEstadoComunicacion)
        {
            this.iEstado = pEstadoComunicacion;
        }

        public void CambiarEstado()
        {
            this.iEstado = this.iEstado == EstadoComunicacion.Enviado ? EstadoComunicacion.No_Enviado : EstadoComunicacion.Enviado;
        }

        public string ObtenerEstado()
        {
            return this.iEstado.ToString();
        }
    }
}
