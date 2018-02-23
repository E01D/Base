using System;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions.Primitives.Strings
{
    public class RequirementApi
    {
        public ArgumentNullException ArgumentIsNull(string argumentName)
        {
            return new ArgumentNullException(argumentName);
        }
    }
}
