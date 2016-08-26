﻿using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Modelo
{
    /// <summary>
    /// Entidad Mensaje, modela un menaje o correo.
    /// </summary>
    public abstract class Mensaje : IMensaje
    {
        //Identificador único del mensaje
        public int Id { get; set; }
        //Asunto del mensaje.
        public string Asunto { get; set; }
        //Identificador de la cuenta asociada.
        public int CuentaId { get; set; }
        //Entidad de la cuenta asociada.
        public ICuenta Cuenta { get; set; }
        // Colección de direcciones de correo como direcciones destinatarios.
        public virtual ICollection<IDireccionCorreo> Destinatario { get; set; }

        private IStatePersistencia iEstadoPersistencia;

        public Mensaje()
        {
            Destinatario = new List<IDireccionCorreo>();
            this.iEstadoPersistencia = new MensajeNoGuardado();
        }

        public void CambiarEstadoPersistencia()
        {
            if (this.iEstadoPersistencia.ObtenerEstadoPersistencia() != Modelo.EstadoPersistencia.Guardado)
                this.iEstadoPersistencia = new MensajeGuardado();
            else
                this.iEstadoPersistencia = new MensajeNoGuardado();

        }

        public IEnumerable<IDireccionCorreo> ObtenerSegun(Expression<Func<IDireccionCorreo, bool>> pCriterio)
        {
            return this.Destinatario.AsQueryable().Where(pCriterio);
        }
        public IDireccionCorreo Obtener(Expression<Func<IDireccionCorreo, bool>> pCriterio)
        {
            return this.Destinatario.AsQueryable().FirstOrDefault(pCriterio);
        }

        public void AgregarNuevoDestinatario(IDireccionCorreo pDireccionCorreo)
        {
            this.Destinatario.Add(pDireccionCorreo);
        }
        public void EliminarDestinatario(IDireccionCorreo pDireccionCorreo)
        {
            this.Destinatario.Remove(pDireccionCorreo);
        }

        public string ObtenerEstadoPersistencia
        {
            get
            {
                return this.iEstadoPersistencia.ObtenerEstadoPersistencia().ToString();
            }
        }


        //IDEA: metodo estático que permita devolver todo el mensaje como un texto plano.

        ////Identificador de la dirección de correo asociada al mensaje, como dirección remitente.
        //public int DireccionId { get; set; }
        ////Entidad de la dirección de correo remitente.
        //public DireccionCorreo DireccionCorreo { get; set; }
    }
}
