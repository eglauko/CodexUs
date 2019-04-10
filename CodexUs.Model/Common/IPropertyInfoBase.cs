namespace CodexUs.Model.Common
{
    /// <summary>
    /// Interface para base de modelos que representam propriedades de classes.
    /// </summary>
    public interface IPropertyInfoBase
    {
        /// <summary>
        /// Obtém o nome para a propriedade.
        /// </summary>
        string PropertyName { get; }

        /// <summary>
        /// Obtém o comentário para a propriedade.
        /// </summary>
        string Comment { get; }

        /// <summary>
        /// Tipo para o c-sharp
        /// </summary>
        CsTypeInfo CsType { get; }
    }
}
