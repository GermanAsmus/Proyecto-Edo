using System.Collections.Generic;

namespace Modelo
{
    /// <summary>
    /// Mensaje Completo
    /// </summary>
    public class Completo : Mensaje
    {
        /// <summary>
        /// Contenido en Texto Plano
        /// </summary>
        public string Contenido { get; set; }
        /// <summary>
        /// Coleccion de Archivos Adjuntos del Mensaje
        /// </summary>
        public virtual ICollection<Adjunto> Adjuntos { get; set; }

        public Completo()
        {
            Adjuntos = new List<Adjunto>();
        }
    }
}
