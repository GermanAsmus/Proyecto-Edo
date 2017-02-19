using Dominio.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using Dominio.Entidades.Helper;
using System.Threading;
using Dominio.Servicio;
using System.Linq;

namespace Dominio.Entidades
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
            return (Pop3)this.Protocolos.Single(p => p.Tipo == pTipo);
        }

        public IProtocoloTransmision ObtenerProtocoloTransmision(TipoProtocolo pTipo = TipoProtocolo.smtp)
        {
            return (Smtp)this.Protocolos.Single(p => p.Tipo == pTipo);
        }

    }
}