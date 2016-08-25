namespace Modelo
{
    public class MensajeNoGuardado : IStatePersistencia
    {
        public IRegistroMensaje RegistroMensaje { get; set; }

        public EstadoPersistencia ObtenerEstadoPersistencia()
        {
            return EstadoPersistencia.No_Guardado;
        }
        public MensajeNoGuardado()
        {
            this.RegistroMensaje = new RegistroMensaje();
        }
    }
}
