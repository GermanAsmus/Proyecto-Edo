using System.Collections.Generic;

namespace Modelo
{
    public interface IRegistrableCollection
    {
        ICollection<IRegistroMensaje> RegistroMensajes { get; }

        void NuevoRegistro(IRegistroMensaje pNuevoRegistro);

        IRegistroMensaje ObtenerUltimoRegistroMensaje();
    }
}
