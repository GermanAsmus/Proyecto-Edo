using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace ControlDependencia
{
    public interface IConexion
    {
        Cuenta CuentaServicio { get; }
        Buzon BuzonServicio { get; }

        void Enviar(Completo mensaje);
        void Descargar(int cantidad);
        void Eliminar(int pUid);
    }
}
