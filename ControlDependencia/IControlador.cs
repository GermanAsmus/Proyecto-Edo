namespace ControlDependencia
{
    public interface IControlador
    {
        IGestor iGestor { get; }
        IConexion iServicio { get; }
    }
}
