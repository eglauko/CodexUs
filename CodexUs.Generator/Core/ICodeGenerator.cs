namespace CodexUs.Generator.Core
{
    /// <summary>
    /// <para>
    ///     Interface para componente geradores de código.
    /// </para>
    /// <para>
    ///     Para cada forma de gerar código haverá um componente específico.
    /// </para>
    /// </summary>
    public interface ICodeGenerator<in TModel>
    {
        /// <summary>
        /// Nome do gerador de código.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gera código a partir de um modelo.
        /// </summary>
        /// <param name="model">Modelo com informações para geração de código.</param>
        /// <returns>O código gerado.</returns>
        string Generate(TModel model);
    }
}
