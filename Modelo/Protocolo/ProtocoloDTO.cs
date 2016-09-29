using CapaInterfaces.Modelo;
using System;
using System.Xml.Serialization;

namespace Modelo
{
    public class ProtocoloDTO : IProtocoloDTO
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

        public ProtocoloDTO()
        {
            this.Id = 0;
        }
        
    }
}
