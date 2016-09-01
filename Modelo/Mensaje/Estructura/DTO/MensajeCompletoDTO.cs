using CapaInterfaces.Modelo;
using System.Collections.Generic;
using CapaInterfaces;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace Modelo
{
    public class MensajeCompletoDTO : MensajeEstructuradoDTO, IMensajeCompletoDTO
    {

        // Contenido en Texto Plano
        public string Contenido { get; set; }

        // Coleccion de adjuntos del mensaje.
        public virtual ICollection<IAdjuntoDTO> Adjuntos { get; set; }

        public MensajeCompletoDTO()
        {
            this.Estructura = EstructuraMensaje.completo;
        }
    }
}