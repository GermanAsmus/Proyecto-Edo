using EdoUI.Entidades.DTO;
using System;
using System.Collections.Concurrent;

namespace EdoUI.Entidades.Helper
{
    /// <summary>
    /// Interfaz que mantiene dos colecciones concurrentes que se actualizan mediante la agregación de Mensajes.
    /// </summary>
    public interface IBuzon
    {
        /// <summary>
        /// Coleccion Concurrente de cabeceras de mensajes
        /// </summary>
        IProducerConsumerCollection<IMensajeDTO> Cabeceras { get; }
        /// <summary>
        /// Coleccion Concurrente de mensajes
        /// </summary>
        IProducerConsumerCollection<IMensajeDTO> Mensajes { get; }
        /// <summary>
        /// Agrega una cabecera a la coleccion Cabeceras
        /// </summary>
        /// <param name="pCabecera">Cabecera de un mensaje</param>
        void AgregarCabecera(IMensajeDTO pCabecera);
        /// <summary>
        /// Agrega un mensaje a la coleccion Mensajes
        /// </summary>
        /// <param name="pMensaje">Un mensaje</param>
        void AgregarMensaje(IMensajeDTO pMensaje);
    }
}
