using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeNuloDTO : MensajeDTO
    {
        public MensajeNuloDTO()
        {
            this.Asunto = string.Empty;
            this.Cuenta = null;
            this.CuentaId = -1;
            this.Destinatario = null;
            this.EstadoPersistencia = EstadoPersistencia.No_Guardado;
            this.Id = -1;
        }
    }
}