using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    public class Servidor : IServidor
    {

        #region propiedades
        //Tipo del servidor.
        public string Nombre { get; set; }

        //Protocolos de comunicacion del servidor
        public ICollection<IProtocolo> Protocolos { get; set; } 
        #endregion

        public Servidor()
        {
            this.Protocolos = new List<IProtocolo>();
        }

        public IProtocoloRecepcion ObtenerProtocoloRecepcion(TipoProtocolo pTipo = TipoProtocolo.pop3)
        {
            return (Pop3)this.Protocolos.First(p => p.Tipo == pTipo);
        }

        public IProtocoloTransmision ObtenerProtocoloTransmision(TipoProtocolo pTipo = TipoProtocolo.smtp)
        {
            return (Smtp)this.Protocolos.First(p => p.Tipo == pTipo);
        }

    }
}