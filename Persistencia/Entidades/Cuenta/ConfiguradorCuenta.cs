using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;
using CapaInterfaces;

namespace Modelo
{
    public static class ConfiguradorCuenta
    {
        internal static IServidorDAO ConfigurarServidor(string pHost)
        {
            bool iEncontrado = true;
            IEnumerator<ICreador<IServidorDAO>> servidorEnumerable = new ControlCreadoresServidor().ObtenerCreadores().GetEnumerator();
            while (iEncontrado && servidorEnumerable.MoveNext())
            {
                //si el nombre del servidor es igual al host entonces iEncontrado = false.
                iEncontrado = (servidorEnumerable.Current as CreadorServidor).ObtenerNombre() == pHost ? false : true;
            }
            return servidorEnumerable.Current.ObtenerEntidad();
        }
    }
}