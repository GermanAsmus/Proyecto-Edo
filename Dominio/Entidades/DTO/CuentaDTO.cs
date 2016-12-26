using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EdoUI.DTO;

namespace Persistencia
{
    public class CuentaDTO : ICuentaDTO
    {
        //Identificador único de la cuenta.
        public int Id { get; set; }

        //Identificador de la direccion de correo de la cuenta
        public int DireccionId { get; set; }

        public IDireccionCorreoDTO DireccionCorreo { get; set; }

        //Colección de mensjes que se relacionan con la cuenta.
        public virtual ICollection<IMensajeDTO> Mensajes { get; set; }

        public IServidorDTO Servidor { get; set; }

        public CuentaDTO(IDireccionCorreoDTO pDireccion = null)
        {
            this.Mensajes = new List<IMensajeDTO>();
            if (this.DireccionCorreo != null)
            {
                string host = DireccionCorreoDTO.ObtenerHost(this.DireccionCorreo);
                this.Servidor = new CreadorServidor().ObtenerServidor(host);
            }
        }
    }
}