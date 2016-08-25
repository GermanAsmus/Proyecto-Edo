using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    //El mensaje incompleto es siempre un mensaje externo, 
    //se plantea de esta manera porque un mensaje que redacta el usuario
    //está sujeto a la restricción de ser completo.
    public class MensajeIncompleto : MensajeSinEstructuraDefinida
    {
        public override IStrategyPertenenciaMensaje Pertenencia { get; }

        public MensajeIncompleto(ICuenta pCuenta) : base(pCuenta)
        {
            this.Pertenencia = new MensajeExterno(pCuenta);
        }

    }
}
