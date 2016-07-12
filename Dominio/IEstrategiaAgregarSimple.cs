using ControlDependencia;

namespace Dominio
{
    /// <summary>
    /// Estratégia de agregación independiente a cualquier otro tipo de entidad del modelo.
    /// </summary>
    /// <typeparam name="T">Tipo de entidad del modelo</typeparam>
    public interface IEstrategiaAgregarSimple<T> : IRepositorioGenerico<T> where T : class
    {
        /// <summary>
        /// Agrega una entidad al sistema
        /// </summary>
        /// <param name="entidad">entidad del tipo T, a agregar en el sistema</param>
        /// <returns>0 si no se pudo completar la operación, sino se ralizó completamente</returns>
        new int Agregar(T entidad);
    }
}
