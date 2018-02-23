using Root.Coding.Code.Api.E01D;

namespace Root.Coding.Code.Domains.E01D.Core
{
    public class XBase
    {
        public static BaseApi Api { get; set; } = new BaseApi();


        public static T CastOrThrow<T>(object x) where T:class
        {
            return Api.Casting.CastOrThrow<T>(x);
        }

        public static bool IsNumeric(object o)
        {
            return Api.Primitives.IsNumeric(o);
        }
    }
}
