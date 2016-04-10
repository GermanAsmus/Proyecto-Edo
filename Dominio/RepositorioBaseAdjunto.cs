using Modelo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ControlDependencia;
using System.Threading.Tasks;
using System.Threading;

namespace Dominio
{
    public class RepositorioBaseAdjunto : AgregarCompuesto<Adjunto,Completo>
    {
        public RepositorioBaseAdjunto(IRepositorio<Adjunto> iRepositorio,IGestor pGestor) : base(iRepositorio,pGestor)
        {
            //Constructor
        }

        public override void Agregar(Adjunto hijo, Completo padre)
        {
            Adjunto hijoResidente = this.Obtener(x => x.AdjuntoId == hijo.AdjuntoId);

            IServicio<Completo> Servicio2 = (IServicio<Completo>)this.GestorServicio.ObtenerServicio(typeof(Completo));
            Completo padreResidente = Servicio2.Obtener(x => x.MensajeId == padre.MensajeId);
            padreResidente.Adjuntos.Add(hijoResidente);

            Servicio2.Editar(padre);
        }
    }
}
