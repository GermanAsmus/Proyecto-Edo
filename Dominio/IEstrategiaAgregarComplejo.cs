using ControlDependencia;

namespace Dominio
{
    /// <summary>
    /// Estrategia de agregación para el tipo T1 sobre T2.
    /// </summary>
    /// <typeparam name="T1">Tipo de entidad dependiente del Tipo de entidad T2</typeparam>
    /// <typeparam name="T2">Tipo de entidad independiente sobre el Tipo de entidad T1</typeparam>
    public interface IEstrategiaAgregarComplejo<T1, T2> : IRepositorioGenerico<T1>
        where T1 : class
        where T2 : class
    {
        /// <summary>
        /// Agrega la entidad hija al sistema, mediante su dependencia con la entidad padre.
        /// </summary>
        /// <param name="pHijo">Entidad del Tipo dependiente del Tipo T2, a agregar en el sistema</param>
        /// <param name="pPadre">Entidad del Tipo independiente sobre el Tipo T1</param>
        /// <returns>0 si se pudo completar la operación, sino se realizó correctamente</returns>
        int Agregar(T1 pHijo, T2 pPadre);
    }
}
