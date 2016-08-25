using CapaInterfaces.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Modelo
{
    /// <summary>
    /// Entidad Adjunto, modela un archivo adjunto que pueda persistir en el sistema.
    /// </summary>
    public class Adjunto : IAdjunto
    {
        //Identificador único del Adjunto.
        public int Id { get; set; }
        //Path o dirección en donde el archivo adjunto se encuentra persistido en el disco.
        public string CodigoAdjunto
        {
            get
            {
                if (!Existe(this.CodigoAdjunto)) throw new NotImplementedException();
                return this.CodigoAdjunto;
            }
            set
            {
                if (Existe(this.CodigoAdjunto)) throw new NotImplementedException();
                this.CodigoAdjunto = value;
            }

        }
        //Colección de mensajes a los que el adjunto está relacionado.
        public virtual ICollection<IMensaje> Mensajes { get; set; }

        public Adjunto()
        {
            Mensajes = new List<IMensaje>();
        }

        private static bool Existe(string pCodigo)
        {
            if (File.Exists(pCodigo))
                return true;
            else
                throw new Exception();
        }

    }
}
