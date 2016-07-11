using System.Collections.Generic;

namespace Modelo
{
    /// <summary>
    /// Entidad Servidor, modela un servidor de correo. Ej: gmail, yahoo, hotmail.
    /// </summary>
    public class Servidor : IEntidadModelo
    {
        //Identificador del servidor.
        public int Id { get; set; }
        //Nombre del servidor.
        public string Nombre { get; set; }
        //Host smtp del servidor.
        public string HostSMTP { get; set; }
        //Host pop3 del servidor.
        public string HostPOP { get; set; }
        //Puerto smtp del servidor.
        public int PuertoSMTP { get; set; }
        //Puerto pop3 del servidor.
        public int PuertoPOP { get; set; }
        //SSL, capa de puertos de seguridad, del servidor.
        public bool SSL { get; set; }
        //Colección de Cuentas asociadas al servidor.
        public virtual ICollection<Cuenta> Cuenta { get; set; }
        public Servidor()
        {
            Cuenta = new List<Cuenta>();
        }
    }
}
