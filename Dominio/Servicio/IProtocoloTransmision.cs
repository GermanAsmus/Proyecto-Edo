using Dominio.Entidades.Interfaces;

namespace Dominio.Servicio
{
    /// <summary>
    /// Protocolo de transmisión de correos.
    /// </summary>
    public interface IProtocoloTransmision
    {
        /// <summary>
        /// Envía un mensaje utilizando la cuenta del usuario.
        /// </summary>
        void Enviar(IMensaje pMensaje, string pDireccion, string pContraseña);
    }
}
