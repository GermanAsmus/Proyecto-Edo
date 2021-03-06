﻿using System;
using EdoUI.DTO;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades.DAO;

namespace Persistencia.Entidades.Mensaje.Estados
{
    public class Visibilidad : IEstadoMensaje
    {
        private EstadoVisibilidad iEstado;

        public Visibilidad()
        {
            this.iEstado = EstadoVisibilidad.No_Visto;
        }
        public Visibilidad(EstadoVisibilidad pEstadoVisibilidad)
        {
            this.iEstado = pEstadoVisibilidad;
        }

        public void CambiarEstado()
        {
            this.iEstado = this.iEstado==EstadoVisibilidad.Visto ? EstadoVisibilidad.No_Visto : EstadoVisibilidad.Visto;
        }

        public string ObtenerEstado()
        {
            return this.iEstado.ToString();
        }
    }
}
