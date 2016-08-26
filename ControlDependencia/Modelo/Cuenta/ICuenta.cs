using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaces.Modelo
{
    public interface ICuenta : IEntidadModelo, IObtenible<IMensaje>
    {
        //Identificador de la direccion de correo de la cuenta
        int DireccionId { get; set; }
        //Entidad de la direccion de correo a la que está relacionada la cuenta.
        IDireccionCorreo DireccionCorreo { get; set; }

        ICollection<IMensaje> Mensajes { get; set; }

        void AgregarNuevoMensaje(IMensaje pMensaje);
        void EliminarMensaje(IMensaje pMensaje);


    }
}
