using CodexUs.Model.Common;

namespace CodexUs.Model.BuildingBlock
{
    /// <summary>
    /// Valor constantes para regras.
    /// </summary>
    public class RuleInfo : BaseInfo
    {
        /// <summary>
        /// Valor da regra.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Regra MaxLength.
        /// </summary>
        /// <param name="value">Valor de MaxLength.</param>
        /// <returns>RuleInfo</returns>
        public static RuleInfo MaxLength(int value) => new RuleInfo()
        {
            Name = "MaxLength",
            Value = value,
            Comment = "",
        };

        /// <summary>
        /// Regra MinLength.
        /// </summary>
        /// <param name="value">Valor de MinLength.</param>
        /// <returns>RuleInfo</returns>
        public static RuleInfo MinLength(int value) => new RuleInfo()
        {
            Name = "MinLength",
            Value = value,
            Comment = "",
        };

        /// <summary>
        /// Regra IsRequired.
        /// </summary>
        /// <returns>RuleInfo</returns>
        public static RuleInfo IsRequired() => new RuleInfo()
        {
            Name = "IsRequired",
            Value = true,
            Comment = "",
        };
    }
}
