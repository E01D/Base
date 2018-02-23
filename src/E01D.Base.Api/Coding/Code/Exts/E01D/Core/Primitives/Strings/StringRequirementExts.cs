using Root.Coding.Code.Domains.E01D.Core;

namespace Root.Coding.Code.Exts.E01D.Core.Primitives.Strings
{
    public static class StringRequirementExts
    {
        public static void ArgumentIsNotNull(this string argumentValue, string argumentName)
        {
            XBase.Api.Primitives.String.Requirements.ArgumentIsNotNull(argumentName, argumentValue);
        }
    }
}
