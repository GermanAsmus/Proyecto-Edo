using ControlDependencia;
using Modelo;
using System;
using System.IO;
using Utilidades.CriteriosDeBusqueda;

namespace Utilidades.Validacion
{
    public class ValidarAdjunto : Validar<Adjunto>
    {
        public override Adjunto Evaluar(Adjunto pEntidad, IRepositorio<Adjunto> pRepositorio)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            //El codigo no puede ser nulo o vacío
            if (string.IsNullOrEmpty(pEntidad.CodigoAdjunto))
                throw new NullReferenceException(nameof(pEntidad));

            if (File.Exists(pEntidad.CodigoAdjunto))
                return pEntidad;
            else
                return pRepositorio.Obtener(x => BuscarAdjunto.BuscarPorId(x, pEntidad.Id));
        }
    }
}
