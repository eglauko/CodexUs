using System;
using System.Collections.Generic;
using System.Text;

namespace CodexUs.Model.Design
{
    /// <summary>
    /// Classe que representa um modelo de domínio com todos os artefatos da modelagem.
    /// </summary>
    public class DomainModel
    {
        /// <summary>
        /// Nome do domínio.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Itens do domínio.
        /// </summary>
        public Items Items { get; private set; } = new Items();
    }
}
