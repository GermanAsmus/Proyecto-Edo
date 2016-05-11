using Modelo;
using System;
using System.Collections.Concurrent;

namespace ControlDependencia.Utilidades
{
    /// <summary>
    /// Interfaz que mantiene dos colecciones concurrentes que se actualizan mediante la agregación de Mensajes.
    /// </summary>
    public interface IBuzon
    {
        /// <summary>
        /// Coleccion Concurrente de cabeceras de mensajes
        /// </summary>
        IProducerConsumerCollection<Mensaje> Cabeceras { get; }
        /// <summary>
        /// Coleccion Concurrente de mensajes
        /// </summary>
        IProducerConsumerCollection<Mensaje> Mensajes { get; }
        /// <summary>
        /// Agrega una cabecera a la coleccion Cabeceras
        /// </summary>
        /// <param name="pCabecera">Cabecera de un mensaje</param>
        void AgregarCabecera(Mensaje pCabecera);
        /// <summary>
        /// Agrega un mensaje a la coleccion Mensajes
        /// </summary>
        /// <param name="pMensaje">Un mensaje</param>
        void AgregarMensaje(Mensaje pMensaje);
    }
}
