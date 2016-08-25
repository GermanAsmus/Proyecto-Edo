using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaces.Modelo
{
    public interface IMensajeCompleto : IMensaje
    {
        // Contenido en Texto Plano
        string Contenido { get; set; }
        // Coleccion de adjuntos del mensaje.
        ICollection<IAdjunto> Adjuntos { get; set; }
    }
}
