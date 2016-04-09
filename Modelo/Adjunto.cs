using System.Collections;
using System.Collections.Generic;

namespace Modelo
{
    public class Adjunto : IEntidad
    {
        public string AdjuntoId { get; set; }

        public virtual ICollection<Completo> Mensajes { get; set; }

        public Adjunto()
        {
            Mensajes = new List<Completo>();
        }
    }
}
