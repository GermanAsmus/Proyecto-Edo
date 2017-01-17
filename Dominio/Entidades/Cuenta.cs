using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dominio.Entidades.Interfaces;

namespace Dominio.Entidades
{
    public class Cuenta : ICuenta
    {
        
        public int Id { get; set; }

        public int DireccionId { get; set; }

        public IDireccionCorreo DireccionCorreo { get; set; }

        public virtual ICollection<IMensaje> Mensajes { get; set; }

        public IServidor Servidor { get; set; }

        public string Contraseña { get; set; }

        public string Nombre { get; set; }

        public Cuenta(IDireccionCorreo pDireccion = null)
        {
            this.Mensajes = new List<IMensaje>();
            if (this.DireccionCorreo != null)
            {
                string host = Entidades.DireccionCorreo.ObtenerHost(this.DireccionCorreo);
                this.Servidor = Entidades.Servidor.ObtenerServidor(host);
            }
        }
    }
}