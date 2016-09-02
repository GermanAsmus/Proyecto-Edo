using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CapaInterfaces.Modelo;
using CapaInterfaces;

namespace Modelo
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

        public IServidorDAO Servidor { get; set; }

    }
}