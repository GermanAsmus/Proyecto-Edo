using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ValidarAdjunto : Validar<Adjunto>
    {
        public ValidarAdjunto(IServicio<Adjunto> pServicio) : base (pServicio)
        {

        }
        public override Adjunto Evaluar(Adjunto entidad)
        {
            //El string no puede ser nulo o vacío
            if (string.IsNullOrEmpty(entidad.AdjuntoId))
                throw new NullReferenceException("AdjuntoId");

            var resultado = this.Servicio.Obtener(x => x.AdjuntoId == entidad.AdjuntoId);
            if (resultado != null)
                return resultado;
            else if (File.Exists(entidad.AdjuntoId))
                return entidad;
            else
                throw new NullReferenceException("AdjuntoId");
        }
    }
}
