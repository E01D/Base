namespace E01D.Core.CommandLines.Api.Code.Api.Core
{
    public class CommandLineApi
    {
        public int GetArgumentOrDefault(string[] args, int argumentIndex, int defaultValue)
        {
            if (args == null || args.Length <= argumentIndex || args[argumentIndex] == null)
            {
                return defaultValue;
            }

            int result;

            if (int.TryParse(args[argumentIndex], out result))
            {
                return result;
            }

            return defaultValue;
        }

        public string GetArgumentOrDefault(string[] args, int argumentIndex, string defaultValue)
        {
            if (args == null || args.Length <= argumentIndex || args[argumentIndex] == null)
            {
                return defaultValue;
            }

            return args[argumentIndex];
        }

        public string GetArgumentOrThrow(string[] args, int argumentIndex, string errorMessage)
        {
            if(args == null || args.Length <= argumentIndex || args[argumentIndex] == null)
            {
                throw new System.Exception(errorMessage);
            }

            return args[argumentIndex];
        }
    }
}
