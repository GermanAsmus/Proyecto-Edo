using System;
using System.Collections.Generic;

namespace Modelo
{
    /// <summary>
    /// Entidad Mensaje, modela un menaje o correo.
    /// </summary>
    public class Mensaje : IEntidadModelo
    {
        //Identificador único del mensaje
        public int Id { get; set; }
        //Código del mensaje que se obtiene de la descarga del servidor.
        public string CodigoMensaje { get; set; }
        //Fecha del mensaje que se obtiene de la descarga del servidor.
        public string Fecha { get; set; }
        //Identificador de la dirección de correo asociada al mensaje, como dirección remitente.
        public int DireccionId { get; set; }
        //Entidad de la dirección de correo remitente.
        public DireccionCorreo DireccionCorreo { get; set; }
        //Asunto del mensaje.
        public string Asunto { get; set; }
        //Identificador de la cuenta asociada.
        public int CuentaId { get; set; }
        //Entidad de la cuenta asociada.
        public Cuenta Cuenta { get; set; }
        //Fecha en que se leyó el mensaje.
        public DateTime Leido { get; set; }

        // Contenido en Texto Plano
        public string Contenido { get; set; }
        // Coleccion de adjuntos del mensaje.
        public virtual ICollection<Adjunto> Adjuntos { get; set; }
        // Colección de direcciones de correo como direcciones destinatarios.
        public virtual ICollection<DireccionCorreo> Destinatario { get; set; }

        public Mensaje()
        {
            Destinatario = new List<DireccionCorreo>();
            Adjuntos = new List<Adjunto>();
        }
    }
}
