namespace CodexUs.Model.Common
{
    /// <summary>
    /// Classe abstrata para informações com Name e Comment.
    /// </summary>
    public abstract class BaseInfo
    {
        /// <summary>
        /// Nome da informação, que terá sentido a cada componente de informação.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Comentários.
        /// </summary>
        public string Comment { get; set; }
    }
}
