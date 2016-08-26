using CapaInterfaces.Modelo;
using System.Collections.Generic;
using CapaInterfaces;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace Modelo
{
    public class MensajeCompleto : MensajeSinEstructuraDefinida, IMensajeCompleto
    {
        public override IStrategyPertenenciaMensaje Pertenencia { get; }

        public MensajeCompleto(ICuenta pCuenta) : base(pCuenta)
        {
            Adjuntos = new List<IAdjunto>();

            if (pCuenta.GetType() == typeof(CuentaExterna))
                this.Pertenencia = new MensajeExterno(pCuenta);
            else
                this.Pertenencia = new MensajeUsuario(pCuenta);
        }

        // Contenido en Texto Plano
        public string Contenido { get; set; }

        // Coleccion de adjuntos del mensaje.
        public virtual ICollection<IAdjunto> Adjuntos { get; set; }

        public IEnumerable<IAdjunto> ObtenerSegun(Expression<Func<IAdjunto, bool>> pCriterio)
        {
            return this.Adjuntos.AsQueryable().Where(pCriterio);
        }

        public IAdjunto Obtener(Expression<Func<IAdjunto, bool>> pCriterio)
        {
            return this.Adjuntos.AsQueryable().FirstOrDefault(pCriterio);
        }

        public void AgregarNuevoAdjunto(IAdjunto pAdjunto)
        {
            this.Adjuntos.Add(pAdjunto);
        }

        public void EliminarAdjunto(IAdjunto pAdjunto)
        {
            this.Adjuntos.Remove(pAdjunto);
        }
    }
}