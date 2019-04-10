using CodexUs.Model.Common;
using System.Collections.Generic;
using System.Linq;

namespace CodexUs.Model.Sql
{
    /// <summary>
    /// Dados de uma tabela lida do banco de dados.
    /// </summary>
    public class DbTableInfo : IEntityInfoBase<DbColumnInfo>
    {
        /// <summary>
        /// Nome da tabela.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Table Scheme
        /// </summary>
        public string Scheme { get; set; }

        /// <summary>
        /// Nome da entidade relacionada a tabela, obtida de 'sys.extended_properties' com valor 'EntityName'.
        /// </summary>
        public string DefaultEntityName { get; set; }

        /// <summary>
        /// Comentário relacionado a tabela, obtida de 'sys.extended_properties' com valor 'EntityComment'.
        /// </summary>
        public string DefaulComment { get; set; }

        /// <summary>
        /// Nome da entidade relacionada a tabela, obtida de 'sys.extended_properties' com valor '{DomainName}.EntityName'.
        /// </summary>
        public string DomainEntityName { get; set; }

        /// <summary>
        /// Comentário relacionado a tabela, obtida de 'sys.extended_properties' com valor '{DomainName}.EntityComment'.
        /// </summary>
        public string DomainComment { get; set; }

        /// <summary>
        /// Informações das colunas da tabela.
        /// </summary>
        public ICollection<DbColumnInfo> Columns { get; set; }

        /// <summary>
        /// Obtém o nome para a entidade.
        /// </summary>
        public string TypeName => DomainEntityName ?? DefaultEntityName ?? Name;

        /// <summary>
        /// Obtém o comentário para a entidade.
        /// </summary>
        public string Comment => DomainComment ?? DefaulComment;

        /// <summary>
        /// Valores de <see cref="Columns"/>.
        /// </summary>
        public IEnumerable<DbColumnInfo> Properties => Columns;

        /// <summary>
        /// Coluna Id.
        /// </summary>
        public DbColumnInfo IdColumn => Columns.First(c => c.IsIdentity);
    }
}
