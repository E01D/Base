using System;
using Root.Code.Attributes.E01D.Types.Classificational.Classifiers;

namespace Root.Code.Models.E01D.Composition.Typing.Classificational.Classifiers
{
    [ClassClassifier]
    public class TestClassifier : TypeClassifier
    {
        public override bool Classify(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
