using System.Collections.Generic;
using System.Threading;

namespace Dominio
{ 
    public interface IServidor
    {
        #region propiedades
        //Tipo del servidor.
        string Nombre { get; set; }

        //Protocolos que utiliza el servidor.
        ICollection<IProtocolo> Protocolos { get; set; }
        #endregion

        IProtocoloRecepcion ObtenerProtocoloRecepcion(TipoProtocolo pTipo = TipoProtocolo.pop3);
        IProtocoloTransmision ObtenerProtocoloTransmision(TipoProtocolo pTipo = TipoProtocolo.smtp);
    }
}