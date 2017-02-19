using Dominio.Entidades.Helper;
using Dominio.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Dominio.Entidades
{
    public class Protocolo : IProtocolo
    {
        #region Propiedades
        public TipoProtocolo Tipo { get; set; }
        //Host del servidor.
        public string Host { get; set; }
        //Puerto del servidor.
        public int Puerto { get; set; }
        //SSL, capa de puertos de seguridad, del servidor.
        public bool SSL { get; set; }
        
        public int Id { get; set; }
        #endregion

        public Protocolo()
        {
            this.Id = 0;
        }
    }
}
