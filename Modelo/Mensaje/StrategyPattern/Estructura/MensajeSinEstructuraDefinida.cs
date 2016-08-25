using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class MensajeSinEstructuraDefinida : Mensaje, IStrategyEstructuraMensaje
    {
        public string ObtenerPertenecia
        {
            get { return this.Pertenencia.ObtenerEstrategiaPertenencia().ToString(); }
        }

        public IStrategyPertenenciaMensaje Pertenencia { get; }

        public MensajeSinEstructuraDefinida(ICuenta pCuenta)
        {

        }
    }
}
