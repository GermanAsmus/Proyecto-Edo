using ControlDependencia;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Dominio
{
    public class RepositorioBaseServidor : AgregarSimple<Servidor>
    {
        public RepositorioBaseServidor(IRepositorio<Servidor> pRepositorio, IGestor pGestor) : base(pRepositorio, pGestor)
        {
            //Constructor
        }

        public override async Task Agregar(Servidor entidad)
        {
            await Task.Yield();
        }
    }
}
