using System.Collections.Generic;
using Root.Code.Attributes.E01D.Types.Classificational.Classifiers;

namespace Root.Code.Models.E01D.Composition.Typing.Classificational.Classifiers
{
    [ClassClassifier]
    [InterfaceClassifier]
    public class ApiClassifier : TypeClassifier
    {
        public override bool Classify(System.Type type)
        {
            if (type.Name.EndsWith("Api")) return true;

            if (type.Namespace != null && type.Namespace.StartsWith("E01D.Api.")) return true;

            return false;
        }

        public IEnumerable<ClassifierFilter> Filters { get; set; }

        // find classifiers
        // find classifier filters
        // connect them together
    }
}
