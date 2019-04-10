using System;
using System.Collections.Generic;
using System.Text;

namespace CodexUs.Model.BuildingBlock
{
    /// <summary>
    /// Projetar classes.
    /// </summary>
    public class EntityInfo
    {
        /// <summary>
        /// Informações do Id.
        /// </summary>
        public IdInfo Id { get; set; }

        /// <summary>
        /// Informações das propriedades da entidade.
        /// </summary>
        public ICollection<PropertyInfo> Properties { get; set; }

        /// <summary>
        /// Conceitos da entidade.
        /// </summary>
        public ICollection<ConceptInfo> Concepts { get; set; }

        /// <summary>
        /// Regras da entidade.
        /// </summary>
        public ICollection<RuleInfo> Rules { get; set; }

        //public ICollection<string> Agregates { get; set; }

        //public ICollection<FactoryInfo> Factories { get; set; }

        //public RepositoryInfo Repository { get; set; }
    }
}
