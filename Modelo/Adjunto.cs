using System;
using System.Collections;
using System.Collections.Generic;

namespace Modelo
{
    /// <summary>
    /// Entidad Adjunto, modela un archivo adjunto que pueda persistir en el sistema.
    /// </summary>
    public class Adjunto : IEntidadModelo
    {
        //Identificador único del Adjunto.
        public int Id { get; set; }
        //Path o dirección en donde el archivo adjunto se encuentra persistido en el disco.
        public string CodigoAdjunto { get; set; }
        //Colección de mensajes a los que el adjunto está relacionado.
        public virtual ICollection<Mensaje> Mensajes { get; set; }

        public Adjunto()
        {
            Mensajes = new List<Mensaje>();
        }
    }
}
