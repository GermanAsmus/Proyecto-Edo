using Modelo;
using System.Collections.Generic;
using System;

namespace ControlDependencia
{
    public interface IGestor
    {
        IServicioRaiz ObtenerServicio(Type tipo);
        IList<IValidar> Validadores { get; set; }
    }
}
