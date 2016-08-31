using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeIncompletoDAO : IMensajeDAO
    {
        public MensajeIncompletoDTO MensajeDTO { get; set; }

        public void CambiarEstadoPersistencia()
        {
            this.MensajeDTO.EstadoPersistencia = this.MensajeDTO.EstadoPersistencia == EstadoPersistencia.Guardado ? EstadoPersistencia.No_Guardado : EstadoPersistencia.Guardado;
        }

        public string ObtenerEstadoPersistencia()
        {
            return this.MensajeDTO.EstadoPersistencia.ToString();
        }
    }
}
