using Modelo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ControlDependencia;
using System.Threading.Tasks;
using System.Threading;

namespace Dominio
{
    public class RepositorioBaseAdjunto : AgregarCompuesto<Adjunto, Completo>
    {
        public RepositorioBaseAdjunto(IRepositorio<Adjunto> iRepositorio, IGestor pGestor) : base(iRepositorio, pGestor)
        {
            //Constructor
        }

        public override async Task Agregar(Adjunto hijo, Completo padre)
        {
            //Adjunto hijoResidente = 

            await Obtener(x => x.AdjuntoId == hijo.AdjuntoId).ContinueWith(async (hijoResidente) =>
              {
                  IServicio<Completo> Servicio2 = (IServicio<Completo>)GestorServicio.ObtenerServicio(typeof(Completo));
                  await Servicio2.Obtener(x => x.MensajeId == padre.MensajeId)
                  .ContinueWith((padreResidente) => { padreResidente.Result.Adjuntos.Add(hijoResidente.Result); })
                  .ContinueWith(async (x) =>
                  { await Servicio2.Editar(padre); });
              });
        }
    }
}
