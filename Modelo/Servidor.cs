using System.Collections.Generic;

namespace Modelo
{
    public class Servidor : IEntidadModelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string HostSMTP { get; set; }
        public string HostPOP { get; set; }
        public int PuertoSMTP { get; set; }
        public int PuertoPOP { get; set; }
        public bool SSL { get; set; }

        public virtual ICollection<Cuenta> Cuenta { get; set; }
        public Servidor()
        {
            Cuenta = new List<Cuenta>();
        }
    }
}
