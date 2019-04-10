using System.Collections.Generic;

namespace CodexUs.Model.Common
{
    /// <summary>
    /// Interface para base de tipos que representam entidades.
    /// </summary>
    public interface IEntityInfoBase
    {
        /// <summary>
        /// Obtém o nome para a entidade.
        /// </summary>
        string TypeName { get; }

        /// <summary>
        /// Obtém o comentário para a entidade.
        /// </summary>
        string Comment { get; }
    }

    /// <summary>
    /// Interface para base de tipos que representam entidades.
    /// </summary>
    /// <typeparam name="TProperty">Tipo da propriedade.</typeparam>
    public interface IEntityInfoBase<TProperty> : IEntityInfoBase
        where TProperty : IPropertyInfoBase
    {
        IEnumerable<TProperty> Properties { get; }
    }
}
