using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeUsuarioFactory : IMensajeFactory
    {
        public IMensajeDTO AgregarEstructura(string pTipoEstructura)
        {
            return new MensajeCompletoDTO();
        }
    }
}