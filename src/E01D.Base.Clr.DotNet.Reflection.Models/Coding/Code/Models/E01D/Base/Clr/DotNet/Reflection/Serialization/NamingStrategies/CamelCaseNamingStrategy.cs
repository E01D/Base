using Root.Coding.Code.Enums.E01D.Reflection.Serialization;

namespace Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection.Serialization.NamingStrategies
{
    public class CamelCaseNamingStrategy: NamingStrategy
    {
        public override NamingStrategyKind Kind => NamingStrategyKind.CamelCase;
    }
}
