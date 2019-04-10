using CodexUs.Generator.Core;
using CodexUs.Model.Sql;

namespace CodexUs.Generator.Sql
{
    /// <summary>
    /// Gerador abstrato para classes a partir de <see cref="DbTableInfo"/>.
    /// </summary>
    public abstract class AbstractSqlCodeGenerator : AbstractCodeGenerator<DbTableInfo, DbColumnInfo>, ISqlCodeGenerator
    {
        /// <summary>
        /// Construtor padrão com o namespace das classes que serão geradas.
        /// </summary>
        /// <param name="namespace"></param>
        public AbstractSqlCodeGenerator(string @namespace) : base(@namespace) { }
    }
}
