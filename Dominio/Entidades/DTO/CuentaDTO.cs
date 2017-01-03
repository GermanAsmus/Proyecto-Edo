using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EdoUI.Entidades.DTO;

namespace Dominio.Entidades.DTO
{
    public class CuentaDTO : ICuentaDTO
    {
        
        public int Id { get; set; }

        public int DireccionId { get; set; }

        public IDireccionCorreoDTO DireccionCorreo { get; set; }

        public virtual ICollection<IMensajeDTO> Mensajes { get; set; }

        public IServidorDTO Servidor { get; set; }

        public CuentaDTO(IDireccionCorreoDTO pDireccion = null)
        {
            this.Mensajes = new List<IMensajeDTO>();
            if (this.DireccionCorreo != null)
            {
                string host = DireccionCorreoDTO.ObtenerHost(this.DireccionCorreo);
                this.Servidor = ServidorDTO.ObtenerServidor(host);
            }
        }
    }
}