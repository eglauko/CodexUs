using CodexUs.Model.Common;
using System.Collections.Generic;

namespace CodexUs.Model.BuildingBlock
{
    /// <summary>
    /// Informações de uma propriedade de uma entidade.
    /// </summary>
    public class PropertyInfo : IPropertyInfoBase
    {
        /// <summary>
        /// Nome da entidade.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Comentários.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Tipo de dado da entidade.
        /// </summary>
        public CsTypeInfo CsType { get; set; }

        /// <summary>
        /// Tipo do tipo da propriedade.
        /// </summary>
        public PropertyTypeKind TypeKind { get; set; }

        /// <summary>
        /// Se a propriedade pode ser sobreescrita.
        /// </summary>
        public bool Overwritable { get; set; }

        /// <summary>
        /// Visibilidade da propriedade.
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Regras da propriedade.
        /// </summary>
        public ICollection<RuleInfo> Rules { get; set; }
    }
}
