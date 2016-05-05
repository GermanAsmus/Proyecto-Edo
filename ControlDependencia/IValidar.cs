namespace ControlDependencia
{
    /// <summary>
    /// Evalúa si una entidad T, cumple con ciertos criterios.
    /// </summary>
    /// <typeparam name="T">Tipo de la entidad que se evalúa</typeparam>
    public interface IValidar<T> where T : class
    {
        /// <summary>
        /// Evalúa una entidad, según ciertos criterios. Se evalúa también si existe en el sistema.
        /// </summary>
        /// <param name="pEntidad">Entidad a evaluar</param>
        /// <param name="pRepositorio">Reposiorio del mismo tipo de la entidad</param>
        /// <returns>Si la entidad es evaluada satisfactoriamente, devuelve dicha entidad</returns>
        T Evaluar(T pEntidad, IRepositorio<T> pRepositorio);
    }
}
