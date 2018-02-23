using Root.Coding.Code.Api.E01D;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XValidation
    {
        public static ValidationApi Api { get; set; } = new ValidationApi();

        public static void ArgumentNotNull(object value, string parameterName)
        {
            Api.ArgumentNotNull(value, parameterName);
        }
    }
}
