using ControlDependencia.Utilidades;
using Modelo;
using System;
using System.Collections.Concurrent;

namespace Utilidades.Misc
{
    /// <summary>
    /// Buzon mantiene dos colecciones, las cabeceras y los mensajes completos,
    /// cuales serán actualizables, particularmente de forma concurrente.
    /// </summary>
    public class Buzon : IBuzon
    {
        // Esta accion sera el trigger para los observadores
        public Action BagChanged;

        public IProducerConsumerCollection<Mensaje> Cabeceras { get; }
        public IProducerConsumerCollection<Mensaje> Mensajes { get; }

        public void AgregarCabecera(Mensaje pCabecera)
        {
            if (pCabecera == null)
                throw new ArgumentNullException(nameof(pCabecera));
            if (!Cabeceras.TryAdd(pCabecera))
                throw new InvalidOperationException("No se pudo agregar la cabecera a la colección del buzon");
            else
                BagChanged();
        }
        public void AgregarMensaje(Mensaje pMensaje)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(nameof(pMensaje));

            if (!Mensajes.TryAdd(pMensaje))
                    throw new InvalidOperationException("No se pudo agregar el mensaje a la colección del buzon");
                else
                    BagChanged();
        }
        public Buzon()
        {
            Cabeceras = new ConcurrentBag<Mensaje>();
            Mensajes = new ConcurrentBag<Mensaje>();
        }
    }
}
