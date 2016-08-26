using System;
using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IMensaje : IEntidadModelo, IObtenible<IDireccionCorreo>
    {
        ////Identificador de la dirección de correo asociada al mensaje, como dirección remitente.
        //public int DireccionId { get; set; }
        ////Entidad de la dirección de correo remitente.
        //public DireccionCorreo DireccionCorreo { get; set; }
        //Asunto del mensaje.
        string Asunto { get; set; }
        //Identificador de la cuenta asociada.
        int CuentaId { get; set; }
        //Entidad de la cuenta asociada.
        ICuenta Cuenta { get; set; }
        
        // Colección de direcciones de correo como direcciones destinatarios.
        ICollection<IDireccionCorreo> Destinatario { get; set; }

        void CambiarEstadoPersistencia();
        string ObtenerEstadoPersistencia { get; }

        void AgregarNuevoDestinatario(IDireccionCorreo pDireccionCorreo);
        void EliminarDestinatario(IDireccionCorreo pDireccionCorreo);
    }
}