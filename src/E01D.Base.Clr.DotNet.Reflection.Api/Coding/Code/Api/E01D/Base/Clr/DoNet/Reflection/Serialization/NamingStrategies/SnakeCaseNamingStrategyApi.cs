using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection.Serialization.NamingStrategies;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection.Serialization.NamingStrategies
{
    public class SnakeCaseNamingStrategyApi
    {
        public string ResolvePropertyName(SnakeCaseNamingStrategy namingStragegy, string name)
        {
            return XStrings.ToSnakeCase(name);
        }
    }
}
