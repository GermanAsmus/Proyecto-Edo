using System;
using System.Collections.Generic;

namespace Dominio.Helper
{
    /// <summary>
    /// La clase tiene como responsabilidad crear el/los mensaje/s que corresponda en cada caso.
    /// </summary>
    public static class CreadorMensajes
    {

        private static IMensaje AgregarDestinatarios(IMensaje pMensajeDTO, ICollection<IDireccionCorreo> pDestinatario)
        {
            foreach (IDireccionCorreo destinatario in pDestinatario)
            {
                pMensajeDTO.Destinatario.Add(destinatario);
            }

            return pMensajeDTO;
        }

        public static IMensaje CrearMensaje(IDireccionCorreo pRemitente, string pAsunto, ICollection<IDireccionCorreo> pDestinatario, string pContenido = "")
        {
            IMensaje iMensajeCompletoDTO = new Mensaje()
            {
                Remitente = pRemitente,
                Asunto = pAsunto,
                Contenido = pContenido,
            };

            return AgregarDestinatarios(iMensajeCompletoDTO, pDestinatario);
        }

    }
}