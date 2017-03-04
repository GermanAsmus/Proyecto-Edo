namespace Dominio
{
    public class Protocolo : IProtocolo
    {
        #region Propiedades
        /// <summary>
        /// Tipo del protocolo. SMTP o POP3
        /// </summary>
        public TipoProtocolo Tipo { get; set; }
        /// <summary>
        /// Host del servidor.
        /// </summary>
        public string Host { get; set; }
        ///<summary>
        ///Puerto del servidor.
        ///</summary>
        public int Puerto { get; set; }
        /// <summary>
        /// SSL, capa de puertos de seguridad, del servidor.
        /// </summary>
        public bool SSL { get; set; }
        #endregion
    }
}
