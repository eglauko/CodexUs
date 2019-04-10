using CodexUs.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodexUs.Sql.SqlServer
{
    /// <summary>
    /// Classe de mapeamento de tipos do sql para tipos do C#.
    /// </summary>
    public class SqlTypesMap
    {
        public Dictionary<string, CsTypeInfo> SqlServer { get; } = new Dictionary<string, CsTypeInfo>()
        {
            { "int", new CsTypeInfo("System", "int")},
            { "bigint", new CsTypeInfo("System", "long")},
            { "smallint", new CsTypeInfo("System", "short")},
            { "tinyint", new CsTypeInfo("System", "byte") },
            { "float", new CsTypeInfo("System", "float")},
            { "real", new CsTypeInfo("System", "double")},
            { "decimal", new CsTypeInfo("System", "decimal")},
            { "money", new CsTypeInfo("System", "decimal")},
            { "smallmoney", new CsTypeInfo("System", "decimal")},
            { "numeric", new CsTypeInfo("System", "decimal")},
            { "bit", new CsTypeInfo("System", "bool")},
            { "binary", new CsTypeInfo("System", "byte[]")},
            { "varbinary", new CsTypeInfo("System", "byte[]")},
            { "image", new CsTypeInfo("System", "byte[]")},
            { "char", new CsTypeInfo("System", "string")},
            { "nchar", new CsTypeInfo("System", "string")},
            { "varchar", new CsTypeInfo("System", "string")},
            { "nvarchar", new CsTypeInfo("System", "string")},
            { "text", new CsTypeInfo("System", "string")},
            { "ntext", new CsTypeInfo("System", "string")},
            { "date", new CsTypeInfo("System", nameof(DateTime))},
            { "datetime", new CsTypeInfo("System", nameof(DateTime))},
            { "datetime2", new CsTypeInfo("System", nameof(DateTime))},
            { "smalldatetime", new CsTypeInfo("System", nameof(DateTime))},
            { "datetimeoffset", new CsTypeInfo("System", nameof(DateTimeOffset))},
            { "time", new CsTypeInfo("System", nameof(TimeSpan))},
            { "timestamp", new CsTypeInfo("System", "long")},
            { "uniqueidentifier", new CsTypeInfo("System", nameof(Guid))},
            { "rowversion", new CsTypeInfo("System", "byte[]") },
        };
    }
}
