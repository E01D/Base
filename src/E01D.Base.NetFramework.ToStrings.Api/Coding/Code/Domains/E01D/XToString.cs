using Root.Coding.Code.Api.E01D.Base.NetFramework;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XToString
    {
        public static ToStringApi Api { get; set; } = new ToStringApi();

        public static string Convert(object currentValue)
        {
            return Api.Convert(currentValue);
        }
    }
}
