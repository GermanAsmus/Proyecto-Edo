using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class Protocolo : IProtocolo
    {
        #region Propiedades
        public string Nombre { get; protected set; }
        //Host del servidor.
        public string Host { get; set; }
        //Puerto del servidor.
        public int Puerto { get; set; }
        //SSL, capa de puertos de seguridad, del servidor.
        public bool SSL { get; set; }
        #endregion

        public Protocolo() { }
        
    }
}
