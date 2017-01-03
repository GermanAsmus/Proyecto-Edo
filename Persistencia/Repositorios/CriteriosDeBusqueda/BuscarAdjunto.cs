using EdoUI.Entidades.DTO;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace Persistencia.Repositorios.CriteriosDeBusqueda
{
    public abstract class BuscarAdjunto
    {
        public Predicate<IAdjuntoDTO> BuscarPorId(int pId)
        {
            return adjunto => adjunto.Id == pId;
        }
        //public Func<IAdjuntoDTO, string, bool> BuscarPorCodigo = (pEntidad, pCodigo) => pEntidad.PathAdjunto == pCodigo;
        
    }

}
