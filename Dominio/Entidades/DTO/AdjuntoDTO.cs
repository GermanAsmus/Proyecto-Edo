using EdoUI.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Dominio.Excepciones;

namespace Dominio.Entidades
{
    /// <summary>
    /// Entidad Adjunto, modela un archivo adjunto que pueda persistir en el sistema.
    /// </summary>
    public class AdjuntoDTO : IAdjuntoDTO
    {
        //Identificador único del Adjunto.
        public int Id { get; set; }
        //Path o dirección en donde el archivo adjunto se encuentra persistido en el disco.
        public string PathAdjunto
        {
            get
            {
                if (!Existe(this.PathAdjunto)) throw new PathInexistenteException();
                return this.PathAdjunto;
            }
            set
            {
                this.PathAdjunto = value;
            }

        }
        //Colección de mensajes a los que el adjunto está relacionado.
        public virtual ICollection<IMensajeDTO> Mensajes { get; set; }

        public AdjuntoDTO()
        {
            Mensajes = new List<IMensajeDTO>();
        }

        private static bool Existe(string pCodigo)
        {
            if (File.Exists(pCodigo))
                return true;
            else
                throw new Exception();
        }

    }
}
