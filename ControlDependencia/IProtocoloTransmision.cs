using Modelo;

namespace ControlDependencia
{
    /// <summary>
    /// Protocolo de transmisión de correos.
    /// </summary>
    public interface IProtocoloTransmision
    {
        /// <summary>
        /// Envía un mensaje utilizando la cuenta del usuario.
        /// </summary>
        /// <param name="pMensaje">Mensaje a enviar</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        void Enviar(Mensaje pMensaje, Cuenta pCuenta);
    }
}
