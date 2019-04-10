using CodexUs.Model.BuildingBlock;
using CodexUs.Model.Sql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodexUs.Model.Design
{
    /// <summary>
    /// Itens de um modelo de domínio.
    /// </summary>
    public class Items
    {
        /// <summary>
        /// Itens de <see cref="DbTableInfo"/> pertencentes a este domínio.
        /// </summary>
        public ICollection<DbTableInfo> DbTypes { get; set; }

        /// <summary>
        /// Itens de <see cref="EntityInfo"/> pertencentes a este domínio.
        /// </summary>
        public ICollection<EntityInfo> Entities { get; set; }
    }
}
