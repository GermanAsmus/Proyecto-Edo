using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class ProtocoloDTO : IProtocoloDTO
    {
        #region Propiedades
        public string Nombre { get; protected set; }
        //Host del servidor.
        public string Host { get; protected set; }
        //Puerto del servidor.
        public int Puerto { get; protected set; }
        //SSL, capa de puertos de seguridad, del servidor.
        public bool SSL { get; protected set; }
        
        public int Id { get; set; }
        #endregion

        public ProtocoloDTO()
        {
            this.Id = 0;
        }
        
    }
}
