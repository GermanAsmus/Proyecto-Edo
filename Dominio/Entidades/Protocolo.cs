using Dominio.Entidades.Interfaces;
using System;

namespace Dominio.Entidades
{
    public class Protocolo : IProtocolo
    {
        #region Propiedades
        public string Tipo { get; set; }
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
