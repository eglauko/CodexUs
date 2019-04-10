using CodexUs.Model.Common;
using System;

namespace CodexUs.Model.BuildingBlock
{
    /// <summary>
    /// Informações sobre uma propriedade Id.
    /// </summary>
    public class IdInfo : IPropertyInfoBase
    {
        /// <summary>
        /// Nome da propriedade.
        /// </summary>
        public string PropertyName { get; }

        /// <summary>
        /// Comentários.
        /// </summary>
        public string Comment { get; }

        /// <summary>
        /// Tipo de dado.
        /// </summary>
        public CsTypeInfo CsType { get; }

        /// <summary>
        /// Novo Id Info.
        /// </summary>
        /// <param name="propertyName">Nome da propriedade Id.</param>
        /// <param name="comment">Comentários.</param>
        /// <param name="csType">Tipo de dado.</param>
        public IdInfo(string propertyName, string comment, CsTypeInfo csType)
        {
            PropertyName = propertyName ?? throw new ArgumentNullException(nameof(propertyName));
            Comment = comment ?? throw new ArgumentNullException(nameof(comment));
            CsType = csType ?? throw new ArgumentNullException(nameof(csType));
        }
    }
}
