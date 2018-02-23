namespace Root.Coding.Code.Models.E01D.Base.Exceptions
{
    public class ArgumentNullException:Exception
    {
        public ArgumentNullException(string argumentName)
            : base($"Argument {argumentName} was null.")
        {
            
        }
    }
}
