using ControlDependencia;
using Modelo;
using System;
using Utilidades.CriteriosDeBusqueda;

namespace Utilidades.Validacion
{
    public class ValidarServidor : Validar<Servidor>
    {
        public override Servidor Evaluar(Servidor pEntidad, IRepositorio<Servidor> pRepositorio)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));
            Servidor unServidor = pRepositorio.Obtener(x => BuscarServidor.BuscarPorNombre(x, pEntidad.Nombre));
            if (unServidor == null)
                throw new ApplicationException("No existe el servidor");
            else
                return unServidor;
        }
    }
}
