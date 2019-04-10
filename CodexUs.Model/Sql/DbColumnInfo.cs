using CodexUs.Model.Common;

namespace CodexUs.Model.Sql
{
    /// <summary>
    /// Informações de uma coluna.
    /// </summary>
    public class DbColumnInfo : IPropertyInfoBase
    {
        /// <summary>
        /// Nome da coluna.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tipo da coluna no banco de dados.
        /// </summary>
        public string DbType { get; set; }

        /// <summary>
        /// Tipo para o c-sharp
        /// </summary>
        public CsTypeInfo CsType { get; set; }

        /// <summary>
        /// Tipo de dado para navegação entre entidades.
        /// </summary>
        public CsTypeInfo NavEntity { get; set; }

        /// <summary>
        /// Se será nullable no c-sharp.
        /// </summary>
        public bool CsNullable { get; set; }

        /// <summary>
        /// Propriedade max_length da coluna.
        /// </summary>
        public int MaxLength { get; set; }

        /// <summary>
        /// Propriedade is_ansi_padded da coluna.
        /// </summary>
        public bool IsAnsiPadded { get; set; }

        /// <summary>
        /// Propriedade is_identity da coluna.
        /// </summary>
        public bool IsIdentity { get; set; }

        /// <summary>
        /// Propriedade is_nullable da coluna.
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Nome da propriedade relacionada a coluna, obtida de 'sys.extended_properties' com valor 'EntityPropertyName'.
        /// </summary>
        public string DefaultPropertyName { get; set; }

        /// <summary>
        /// Comentário relacionado a coluna, obtida de 'sys.extended_properties' com valor 'EntityPropertyComment'.
        /// </summary>
        public string DefaulComment { get; set; }

        /// <summary>
        /// Nome da propriedade relacionada a coluna, obtida de 'sys.extended_properties' com valor '{DomainName}.EntityPropertyName'.
        /// </summary>
        public string DomainPropertyName { get; set; }

        /// <summary>
        /// Comentário relacionado a coluna, obtida de 'sys.extended_properties' com valor '{DomainName}.EntityPropertyComment'.
        /// </summary>
        public string DomainComment { get; set; }

        /// <summary>
        /// Obtém o nome para a propriedade.
        /// </summary>
        public string PropertyName => DomainPropertyName ?? DefaultPropertyName ?? Name;

        /// <summary>
        /// Obtém o comentário para a propriedade.
        /// </summary>
        public string Comment => DomainComment ?? DefaulComment ?? $"TODO: summary for property {Name}.";
    }
}