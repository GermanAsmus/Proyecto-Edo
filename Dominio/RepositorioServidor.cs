using ControlDependencia;
using ControlDependencia.Dominio;
using Modelo;

namespace Dominio
{
    public class RepositorioServidor : RepositorioAbstracto<Servidor>, IEstrategiaAgregarSimple<Servidor>
    {
        public RepositorioServidor(IRepositorio<Servidor> pRepositorio, IGestorRespositorios pGestor) : base(pRepositorio, pGestor)
        {
            //Constructor
        }

        public int Agregar(Servidor pEntidad)
        {
            return this.Repositorio.Agregar(pEntidad);
        }
    }
}
