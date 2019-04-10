using CodexUs.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodexUs.Generator.Core
{
    public abstract class AbstractCodeGenerator<TModel, TProperty> : ICodeGenerator<TModel>
        where TModel : class, IEntityInfoBase<TProperty>
        where TProperty : class, IPropertyInfoBase
    {
        /// <summary>
        /// O nome do gerador de código.s
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// O Modelo atual para geração de código.
        /// </summary>
        protected TModel CurrentModel { get; private set; }

        /// <summary>
        /// Namespace para geração das classes.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Valores dos usings que deverão ser incluídos na geração
        /// </summary>
        public ICollection<string> Usings { get; }

        public AbstractCodeGenerator(string @namespace)
        {
            Namespace = @namespace;
            Usings = new List<string>()
            {
                "System", "System.Collections.Generic", "System.Linq", "System.Text", "System.Threading.Tasks"
            };
        }

        public virtual string StartOfFile()
        {
            return string.Empty;
        }

        public virtual string UsingsDeclaration() => string.Join("\n", Usings.Select(u => $"using {u};"));
        
        public virtual string NamespaceDeclaration(string ns)
        {
            return $@"

namespace {ns}
{{";
        }

        public virtual string ClassDeclaration()
        {
            var declaration = ClassExtendedTypesDeclaration();
            var extends = string.IsNullOrWhiteSpace(declaration)
                ? string.Empty
                : (" : " + declaration);

            return $@"
    /// <summary>
    /// {CurrentModel.Comment ?? $"TODO: summary for {Name}."}
    /// </summary>
    public class {MakeClassName()}{extends}
    {{";
        }

        public virtual string MakeClassName() => CurrentModel.TypeName;

        public abstract string ClassExtendedTypesDeclaration();

        public abstract string InitialPropertyDeclaration();

        public abstract string PropertyDeclaration(TProperty property);

        public abstract string EndOfPropertyDeclaration();

        public virtual string ConstrutorDeclaration()
        {
            var baseDeclaration = ConstrutorBaseDeclaration();
            if (baseDeclaration != null)
                baseDeclaration = " : " + baseDeclaration;
            var comment = CurrentModel.Comment ?? $"Construtor para {CurrentModel.TypeName}.";
            var parms = ConstrutorParams() ?? string.Empty;
            var parmsComments = string.Empty;
            return $@"
        /// <summary>
        /// {comment}
        /// </summary>{parmsComments}
        public {MakeClassName()}({parms}){baseDeclaration}
        {{";
        }

        public abstract string ConstrutorParams();

        public abstract string ConstrutorBaseDeclaration();

        public abstract string ConstrutorInitial();

        public abstract string ConstrutorBody(TProperty property);

        public abstract string ConstrutorEnd();

        public virtual string EndOfConstrutorDeclaration()
        {
            return @"
        }";
        }

        public abstract string InitialMethodDeclaration();

        public abstract string MethodDeclaration(TProperty property);

        public abstract string EndOfMethodDeclaration();

        public virtual string EndOfClassDeclaration()
        {
            return @"
    }";
        }

        public virtual string EndOfNamespace()
        {
            return @"
}";
        }

        public virtual string EndOfFile()
        {
            return "\n";
        }


        public string Generate(TModel model)
        {
            if (CurrentModel != null)
                throw new InvalidOperationException(
                    "Other Model is running Generate with this object. It's not possible gererate two class with same Generator object. Run one by one, or use more instaces of the Generator.");

            CurrentModel = model ?? throw new ArgumentNullException(nameof(model));

            var sb = new StringBuilder(StartOfFile());
            sb.Append(UsingsDeclaration())
                .Append(NamespaceDeclaration(Namespace))
                .Append(ClassDeclaration())
                .Append(InitialPropertyDeclaration() ?? string.Empty);

            foreach (var column in model.Properties)
            {
                sb.Append(PropertyDeclaration(column) ?? string.Empty);
            }

            sb.Append(EndOfPropertyDeclaration() ?? string.Empty)
                .Append(ConstrutorDeclaration())
                .Append(ConstrutorInitial() ?? string.Empty);

            foreach (var column in model.Properties)
            {
                sb.Append(ConstrutorBody(column) ?? string.Empty);
            }

            sb.Append(ConstrutorEnd() ?? string.Empty)
                .Append(EndOfConstrutorDeclaration())
                .Append(InitialMethodDeclaration() ?? string.Empty);

            foreach (var column in model.Properties)
            {
                sb.Append(MethodDeclaration(column) ?? string.Empty);
            }

            sb.Append(EndOfMethodDeclaration() ?? string.Empty)
                .Append(EndOfClassDeclaration())
                .Append(EndOfNamespace())
                .Append(EndOfFile() ?? string.Empty);

            CurrentModel = null;

            return sb.ToString();
        }
    }
}
