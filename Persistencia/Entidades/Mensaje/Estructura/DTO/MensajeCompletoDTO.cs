using CapaInterfaces.Modelo;
using System.Collections.Generic;
using CapaInterfaces;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace Modelo
{
    public class MensajeCompletoDTO : MensajeEstructuradoDTO, IMensajeCompletoDTO
    {


        public MensajeCompletoDTO()
        {
            this.Estructura = EstructuraMensaje.completo;
        }
    }
}