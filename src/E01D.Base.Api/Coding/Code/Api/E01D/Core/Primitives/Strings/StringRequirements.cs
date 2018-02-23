namespace Root.Coding.Code.Api.E01D.Core.Primitives.Strings
{
    public class StringRequirements
    {
        public void ArgumentIsNotNull(string argumentName, string argumentValue)
        {
            if (argumentValue != null) return;

            //throw Primitives.Exceptions.Strings.Requirements.ArgumentIsNull(argumentName);
            throw new System.Exception("Argument is not null");
        }
    }
}
