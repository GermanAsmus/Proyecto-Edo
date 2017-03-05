namespace Dominio
{
    /// <summary>
    /// Protocolo de transmisión de correos.
    /// </summary>
    public interface IProtocoloTransmision
    {
        /// <summary>
        /// Envía un mensaje utilizando la cuenta del usuario.
        /// </summary>
        void Enviar(IMensajeDTO pMensaje, string pDireccion, string pContraseña);
    }
}
