using Root.Coding.Code.Api.E01D.Core;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XNumeric
    {
        public static NumericApi Api { get; set; } = new NumericApi();

        public static string EnsureDecimalPlace(double value, string text)
        {
            return Api.EnsureDecimalPlace(value, text);
        }

        public static string EnsureDecimalPlace(string text)
        {
            return Api.EnsureDecimalPlace(text);
        }
    }
}
