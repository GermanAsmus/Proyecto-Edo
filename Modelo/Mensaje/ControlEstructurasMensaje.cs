using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Modelo
{
    public class ControlEstructurasMensaje
    {
        private static IDictionary<string, IMensajeDTO> iEstructuras;

        public ControlEstructurasMensaje()
        {
            iEstructuras = new Dictionary<string, IMensajeDTO>();
            var clasesDerivadas = Assembly.GetExecutingAssembly().GetTypes()
                .Where(d => d.IsSubclassOf(typeof(MensajeDAO))).ToList();
            foreach (var claseDerivada in clasesDerivadas)
            {
                IMensajeDAO creador = (IMensajeDAO)Activator.CreateInstance(claseDerivada);
                iEstructuras.Add(claseDerivada.Name, creador as IMensajeDTO);
            }
        }

        public IDictionary<string, IMensajeDTO> ObtenerEstructuras()
        {
            return iEstructuras;
        }
    }
}