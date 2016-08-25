using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeCompleto : Mensaje, IMensajeCompleto, IStrategyEstructuraMensaje
    {
        public IStrategyPertenenciaMensaje Pertenencia { get; set; }

        public MensajeCompleto(ICuenta pCuenta, EstrategiaPertenencia pPertenencia)
        {
            Adjuntos = new List<IAdjunto>();

            if (pPertenencia == EstrategiaPertenencia.Externo)
                this.Pertenencia = new MensajeExterno(pCuenta);
            else
                this.Pertenencia = new MensajeUsuario(pCuenta);
        }

        // Contenido en Texto Plano
        public string Contenido { get; set; }

        // Coleccion de adjuntos del mensaje.
        public virtual ICollection<IAdjunto> Adjuntos { get; set; }

    }
}