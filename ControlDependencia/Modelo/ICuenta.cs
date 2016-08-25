using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaces.Modelo
{
    public interface ICuenta : IEntidadModelo
    {
        //Identificador de la direccion de correo de la cuenta
        int DireccionId { get; set; }
        //Entidad de la direccion de correo a la que está relacionada la cuenta.
        IDireccionCorreo DireccionCorreo { get; set; }

    }
}
