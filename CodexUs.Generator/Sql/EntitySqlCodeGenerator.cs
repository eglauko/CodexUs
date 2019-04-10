using CodexUs.Model.Sql;

namespace CodexUs.Generator.Sql
{
    /// <summary>
    /// Classe para geração de entidades a partir de um modelo de tabela SQL.
    /// </summary>
    public class EntitySqlCodeGenerator : AbstractSqlCodeGenerator
    {
        /// <summary>
        /// Construtor padrão com o namespace que será utilizado para geração das classes.
        /// </summary>
        /// <param name="namespace">Namespace.</param>
        public EntitySqlCodeGenerator(string @namespace) : base(@namespace) { }

        /// <summary>
        /// Nome do gerador de código.
        /// </summary>
        public override string Name => "EntityFromSQL";

        /// <summary>
        /// Implementação de IEntity{TId}.
        /// </summary>
        /// <returns></returns>
        public override string ClassExtendedTypesDeclaration() => $"IEntity<{CurrentModel.IdColumn.CsType.Name}>";

        /// <summary>
        /// Cria propriedade de Id.
        /// </summary>
        /// <returns>Código da propriedade do Id.</returns>
        public override string InitialPropertyDeclaration()
        {
            return $@"
        /// <summary>
        /// {CurrentModel.IdColumn.Comment ?? "ID"}.
        /// </summary>
        public {CurrentModel.IdColumn.CsType.Name} {CurrentModel.IdColumn.PropertyName} {{ get; set; }}
        ";
        }

        /// <summary>
        /// Gera as propriedades baseadas nas colunas.
        /// </summary>
        /// <param name="column">Coluna.</param>
        /// <returns>Código de uma propriedade.</returns>
        public override string PropertyDeclaration(DbColumnInfo column)
        {
            if (column.IsIdentity)
                return null;

            if (column.NavEntity != null)
            {
                var name = column.PropertyName.StartsWith("Id")
                    ? column.PropertyName.Substring(2)
                    : column.PropertyName.EndsWith("Id")
                        ? column.PropertyName.Substring(0, column.PropertyName.Length - 2)
                        : column.PropertyName;
                return $@"
        /// <summary>
        /// {column.Comment ?? ("TODO: summary for " + name)}.
        /// </summary>
        public {column.NavEntity.Name} {name} {{ get; set; }}
        ";
            }

            return $@"
        /// <summary>
        /// {column.Comment ?? ("TODO: summary for " + column.PropertyName)}.
        /// </summary>
        public {column.CsType.Name} {column.PropertyName} {{ get; set; }}
        ";
        }

        /// <summary>
        /// null.
        /// </summary>
        /// <returns>null.</returns>
        public override string ConstrutorBaseDeclaration() => null;

        /// <summary>
        /// null.
        /// </summary>
        /// <param name="column">Coluna.</param>
        /// <returns>null.</returns>
        public override string ConstrutorBody(DbColumnInfo column) => null;

        /// <summary>
        /// null.
        /// </summary>
        /// <returns>null.</returns>
        public override string ConstrutorEnd() => null;

        /// <summary>
        /// null.
        /// </summary>
        /// <returns>null.</returns>
        public override string ConstrutorInitial() => null;

        /// <summary>
        /// null.
        /// </summary>
        /// <returns>null.</returns>
        public override string ConstrutorParams() => null;

        /// <summary>
        /// null.
        /// </summary>
        /// <returns>null.</returns>
        public override string EndOfMethodDeclaration() => null;

        /// <summary>
        /// null.
        /// </summary>
        /// <returns>null.</returns>
        public override string EndOfPropertyDeclaration() => null;

        /// <summary>
        /// null.
        /// </summary>
        /// <returns>null.</returns>
        public override string InitialMethodDeclaration() => null;

        /// <summary>
        /// null.
        /// </summary>
        /// <param name="column">Coluna.</param>
        /// <returns>null.</returns>
        public override string MethodDeclaration(DbColumnInfo column) => null;
    }
}
