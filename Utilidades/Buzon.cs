using ControlDependencia;
using Modelo;
using System;
using System.Collections.Concurrent;

namespace Utilidades
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
            if (!Cabeceras.TryAdd(pCabecera))
                throw new Exception();
            else
                BagChanged();
        }
        public void AgregarMensaje(Mensaje pMensaje)
        {
            if (!Mensajes.TryAdd(pMensaje))
                throw new Exception();
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
