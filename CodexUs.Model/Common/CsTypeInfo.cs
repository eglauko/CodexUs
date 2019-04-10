using System;
using System.Reflection;

namespace CodexUs.Model.Common
{
    /// <summary>
    /// Tipo de dado do c-sharp, <see cref="Type"/>.
    /// </summary>
    public class CsTypeInfo
    {
        /// <summary>
        /// Type namespace, <see cref="Type.Namespace"/>.
        /// </summary>
        public string Namespace { get; private set; }

        /// <summary>
        /// Type name, <see cref="MemberInfo.Name"/>.
        /// </summary>
        public string Name { get; private set; }

        public CsTypeInfo(string @namespace, string name)
        {
            Namespace = @namespace ?? throw new ArgumentNullException(nameof(@namespace));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
