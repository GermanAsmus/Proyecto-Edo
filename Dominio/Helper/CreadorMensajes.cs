using System;
using System.Collections.Generic;

namespace Dominio.Helper
{
    /// <summary>
    /// La clase tiene como responsabilidad crear el/los mensaje/s que corresponda en cada caso.
    /// </summary>
    public static class CreadorMensajes
    {

        private static IMensajeDTO AgregarDestinatarios(IMensajeDTO pMensajeDTO, ICollection<IDireccionCorreo> pDestinatario)
        {
            foreach (DireccionCorreo destinatario in pDestinatario)
            {
                pMensajeDTO.Destinatario.Add(destinatario);
            }

            return pMensajeDTO;
        }

        public static IMensajeDTO CrearMensaje(IDireccionCorreo pRemitente, string pAsunto, ICollection<IDireccionCorreo> pDestinatario, string pContenido = "")
        {
            IMensajeDTO iMensajeCompletoDTO = new Mensaje()
            {
                Remitente = (DireccionCorreo)pRemitente,
                Asunto = pAsunto,
                Contenido = pContenido,
            };

            return AgregarDestinatarios(iMensajeCompletoDTO, pDestinatario);
        }

    }
}