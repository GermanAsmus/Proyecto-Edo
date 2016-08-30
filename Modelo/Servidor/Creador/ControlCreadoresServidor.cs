using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Modelo
{
    //Obtiene la lista de todos los creadores de servidor que existen en el proyecto.
    public class ControlCreadoresServidor
    {
        private static IDictionary<string, CreadorServidor> iCreadores;

        public ControlCreadoresServidor()
        {
            iCreadores = new Dictionary<string,CreadorServidor>();
            var clasesDerivadas = Assembly.GetExecutingAssembly().GetTypes()
                .Where(d => d.IsSubclassOf(typeof(CreadorServidor))).ToList();
            foreach (var claseDerivada in clasesDerivadas)
            {
                CreadorServidor creador = (CreadorServidor)Activator.CreateInstance(claseDerivada);
                iCreadores.Add(creador.ObtenerNombre(), creador);
            }
        }

        public IDictionary<string, CreadorServidor> ObtenerCreadores()
        {
            return iCreadores;
        }
    }
}