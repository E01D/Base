using System;

namespace Root.Coding.Code.Api.E01D.Core.Primitives.Exceptions.Strings
{
    public class RequirementApi
    {
        public ArgumentNullException ArgumentIsNull(string argumentName)
        {
            return new ArgumentNullException(argumentName);
        }
    }
}
