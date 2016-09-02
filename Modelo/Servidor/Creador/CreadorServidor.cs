using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public abstract class CreadorServidor : Creador<IServidorDAO>
    {
        public abstract string ObtenerNombre();
    }
}