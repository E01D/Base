using Root.Code.Attributes.E01D.Types.Classificational.FilterTargets;
using Root.Code.Models.E01D.Composition.Typing.Classificational.Classifiers;

namespace Root.Code.Models.E01D.Composition.Typing.Classificational.Filters
{
    [ClassifierFilterTarget(typeof(ApiClassifier))]
    public class ApiFilterByName: ClassifierFilter_I
    {
    }
}
