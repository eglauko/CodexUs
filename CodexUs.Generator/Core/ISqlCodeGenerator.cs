using CodexUs.Model.Sql;

namespace CodexUs.Generator.Core
{
    /// <summary>
    /// <para>
    ///     Componente para geração de código a partir de componentes SQL.
    /// </para>
    /// </summary>
    public interface ISqlCodeGenerator : ICodeGenerator<DbTableInfo> { }
}
