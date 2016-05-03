using System;
using System.Collections;
using System.Collections.Generic;

namespace Modelo
{
    public class Adjunto : IEntidadModelo
    {

        public int Id { get; set; }

        public string CodigoAdjunto { get; set; }

        public virtual ICollection<Mensaje> Mensajes { get; set; }

        public Adjunto()
        {
            Mensajes = new List<Mensaje>();
        }
    }
}
