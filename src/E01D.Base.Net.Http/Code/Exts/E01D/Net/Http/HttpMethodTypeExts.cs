using Root.Code.Enums.E01D.Net.Http;
using Root.Code.Shortcuts.E01D;

namespace Root.Code.Exts.E01D.Net.Http
{
    public static class HttpMethodTypeExts
    {
        public static string Name(this HttpMethodType methodType)
        {
            return XHttp.Api.GetMethodTypeName(methodType);
        }
    }
}
