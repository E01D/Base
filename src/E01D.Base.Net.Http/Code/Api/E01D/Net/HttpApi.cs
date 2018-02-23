using System;
using Root.Code.Api.E01D.Net.Http;
using Root.Code.Enums.E01D.Net.Http;

namespace Root.Code.Api.E01D.Net
{
    public class HttpApi
    {
        public ConfigurationalApi Configurational { get; set; } = new ConfigurationalApi();

        public HttpRequestApi Requests { get; set; } = new HttpRequestApi();

        public HttpResponseApi Responses { get; set; } = new HttpResponseApi();

        public string GetMethodTypeName(HttpMethodType methodType)
        {
            switch (methodType)
            {
                case HttpMethodType.UNKNOWN:
                    return "UNKNOWN";
                case HttpMethodType.DELETE:
                    return "DELETE";
                case HttpMethodType.GET:
                    return "GET";
                case HttpMethodType.HEAD:
                    return "HEAD";
                case HttpMethodType.MERGE:
                    return "MERGE";
                case HttpMethodType.OPTIONS:
                    return "OPTIONS";
                case HttpMethodType.PATCH:
                    return "PATCH";
                case HttpMethodType.POST:
                    return "POST";
                case HttpMethodType.PUT:
                    return "PUT";
                default:
                    throw new ArgumentOutOfRangeException(nameof(methodType), methodType, null);
            }
        }
    }
}
