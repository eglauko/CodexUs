namespace CodexUs.Sql.SqlServer
{
    /// <summary>
    /// Nome de extended_properties do SqlServer para valores vinculados a tabelas e columas.
    /// </summary>
    public class ExtendedProperties
    {
        /// <summary>
        /// Nome da entidade vinculado a uma tabela.
        /// </summary>
        public const string EntityName = "EntityName";

        /// <summary>
        /// Comentário da tabela.
        /// </summary>
        public const string EntityComment = "EntityComment";

        /// <summary>
        /// Nome da propriedade vinculada a uma coluna.
        /// </summary>
        public const string EntityPropertyName = "EntityPropertyName";

        /// <summary>
        /// Comentário de uma coluna.
        /// </summary>
        public const string EntityPropertyComment = "EntityPropertyComment";
    }
}
