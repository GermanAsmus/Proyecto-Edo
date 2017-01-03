using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Dominio.Excepciones;
using EdoUI.Entidades.DTO;

namespace Dominio.Entidades.DTO
{

    public class AdjuntoDTO : IAdjuntoDTO
    {
        public int Id { get; set; }
        
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
