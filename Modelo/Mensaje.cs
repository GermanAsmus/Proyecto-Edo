using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Mensaje : IEntidadModelo
    {
        public int Id { get; set; }

        public string CodigoMensaje { get; set; }
        public string Fecha { get; set; }

        public int DireccionId { get; set; }
        public DireccionCorreo DireccionCorreo { get; set; }

        public string Asunto { get; set; }

        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }

        public DateTime Leido { get; set; }

        /// <summary>
        /// Contenido en Texto Plano
        /// </summary>
        public string Contenido { get; set; }
        /// <summary>
        /// Coleccion de Archivos Adjuntos del Mensaje
        /// </summary>
        public virtual ICollection<Adjunto> Adjuntos { get; set; }

        public virtual ICollection<DireccionCorreo> Destinatario { get; set; }

        public Mensaje()
        {
            Destinatario = new List<DireccionCorreo>();
            Adjuntos = new List<Adjunto>();
        }
    }
}
