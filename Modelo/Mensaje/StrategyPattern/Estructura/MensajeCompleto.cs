using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeCompleto : MensajeSinEstructuraDefinida, IMensajeCompleto
    {
        public override IStrategyPertenenciaMensaje Pertenencia { get; }

        public MensajeCompleto(ICuenta pCuenta) : base(pCuenta)
        {
            Adjuntos = new List<IAdjunto>();

            if (pCuenta.GetType() == typeof(CuentaExterna))
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