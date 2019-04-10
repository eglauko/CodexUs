using System.Collections.Generic;

namespace CodexUs.Model.Common
{
    /// <summary>
    /// Tipo que o tipo de uma propriedade pode assumir.
    /// </summary>
    public enum PropertyTypeKind
    {
        /// <summary>
        /// Propriedades escalar.
        /// </summary>
        Scalar,

        /// <summary>
        /// Propriedades que são <see cref="ICollection{T}"/>.
        /// </summary>
        Collection,

        /// <summary>
        /// Propriedades que são <see cref="IEnumerable{T}"/>.
        /// </summary>
        Enumerable,

        /// <summary>
        /// Propriedades que são <see cref="IEnumerable{T}"/> e que contém uma campo do tipo <see cref="ICollection{T}"/>.
        /// </summary>
        EnumerableWithCollectionField,
    }
}
