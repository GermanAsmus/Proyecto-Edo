using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //public delegate void ChangedEventHandler(object sender, EventArgs e);
    /// <summary>
    /// Buzon mantiene dos colecciones, las cabeceras y los mensajes completos,
    /// cuales serán actualizables, particularmente de forma concurrente.
    /// </summary>
    public class Buzon
    {
        // Esta accion sera el trigger para los observadores
        public Action BagChanged;

        //public event ChangedEventHandler Changed;

        //protected virtual void OnChanged(EventArgs e)
        //{
        //    if (Changed != null)
        //        Changed(this, e);
        //}

        public ConcurrentBag<Mensaje> Cabeceras { get; }
        public ConcurrentBag<Mensaje> Mensajes { get; }

        public void agregarCabecera(Mensaje pCabecera)
        {
            Cabeceras.Add(pCabecera);
            //OnChanged(EventArgs.Empty);
            BagChanged();
        }
        public void agregarMensaje(Mensaje pMensaje)
        {
            Mensajes.Add(pMensaje);
            //OnChanged(EventArgs.Empty);
            BagChanged();
        }
        public Buzon()
        {
            Cabeceras = new ConcurrentBag<Mensaje>();
            Mensajes = new ConcurrentBag<Mensaje>();


        }
    }
}
