namespace Modelo
{
    //El mensaje incompleto es siempre un mensaje externo, 
    //se plantea de esta manera porque un mensaje que redacta el usuario
    //está sujeto a la restricción de ser completo.
    public class MensajeIncompletoDTO : MensajeEstructuradoDTO
    {
        public MensajeIncompletoDTO()
        {
            this.Estructura = EstructuraMensaje.incompleto;
        }
    }
}
