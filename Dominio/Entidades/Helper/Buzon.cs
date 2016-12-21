using EdoUI.DTO;
using System;
using System.Collections.Concurrent;

namespace Dominio.Entidades.Helper
{
    /// <summary>
    /// Buzon mantiene dos colecciones, las cabeceras y los mensajes completos,
    /// cuales serán actualizables, particularmente de forma concurrente.
    /// </summary>
    public class Buzon : IBuzon
    {
        // Esta accion sera el trigger para los observadores
        public Action BagChanged;

        public IProducerConsumerCollection<IMensajeDTO> Cabeceras { get; }
        public IProducerConsumerCollection<IMensajeDTO> Mensajes { get; }

        public void AgregarCabecera(IMensajeDTO pCabecera)
        {
            if (pCabecera == null)
                throw new ArgumentNullException(nameof(pCabecera));
            if (!Cabeceras.TryAdd(pCabecera))
                throw new InvalidOperationException("No se pudo agregar la cabecera a la colección del buzon");
            else
                BagChanged();
        }
        public void AgregarMensaje(IMensajeDTO pMensaje)
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
            Cabeceras = new ConcurrentBag<IMensajeDTO>();
            Mensajes = new ConcurrentBag<IMensajeDTO>();
        }
    }
}
