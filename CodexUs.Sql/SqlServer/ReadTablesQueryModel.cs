using CodexUs.Model.Sql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodexUs.Sql.SqlServer
{
    /// <summary>
    /// Modelo de dados da query de leitura dos dados das tabelas para geração de componentes
    /// de modelo do tipo <see cref="DbTableInfo"/> e <see cref="DbColumnInfo"/>
    /// </summary>
    public class ReadTablesQueryModel
    {
        public int object_id { get; set; }
        public string table_name { get; set; }
        public string entity { get; set; }
        public object class_comment { get; set; }
        public string letra { get; set; }
        public int column_id { get; set; }
        public string name { get; set; }
        public string property { get; set; }
        public object property_comment { get; set; }
        public string col_type { get; set; }
        public object cs_type_ep { get; set; }
        public string cs_nullable { get; set; }
        public int max_length { get; set; }
        public object nav_entity { get; set; }
        public bool is_ansi_padded { get; set; }
        public bool is_identity { get; set; }
        public bool is_nullable { get; set; }
    }
}
