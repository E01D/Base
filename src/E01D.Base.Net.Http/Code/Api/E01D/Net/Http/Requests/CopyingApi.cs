using System.Net;
using Root.Code.Exts.E01D.Core.Collections;
using Root.Code.Exts.E01D.Net.Http;

namespace Root.Code.Api.E01D.Net.Http.Requests
{
    public class CopyingApi
    {
        public void CopyToWebRequest(Root.Code.Models.E01D.Net.Http.Web.HttpWebRequest request)
        {
            // Note - only override the web request default values when null is ok, or there is a value.

            // Set the HTTP method name
            request.NetworkClient.Method = request.Definition.MethodType.Name();

            CopyAuthentication(request);

            CopyCookies(request);

            CopyHeaders(request);

            CopyNonCategorizedProperties(request);

            CopyTimeouts(request);
        }

        private void CopyAuthentication(Root.Code.Models.E01D.Net.Http.Web.HttpWebRequest request)
        {
            request.NetworkClient.UseDefaultCredentials = request.Definition.UseDefaultCredentials;

            request.NetworkClient.PreAuthenticate = request.Definition.PreAuthenticate;

            if (request.Definition.Credentials != null)
            {
                request.NetworkClient.Credentials = request.Definition.Credentials;
            }

            request.NetworkClient.ServerCertificateValidationCallback = request.Definition.ServerCertificateValidationCallback;
        }

        private void CopyCookies(Root.Code.Models.E01D.Net.Http.Web.HttpWebRequest request)
        {
            request.NetworkClient.CookieContainer = request.NetworkClient.CookieContainer ?? new CookieContainer();

            for (int i = 0; i < request.Definition.Headers.Count; i++)
            {
                var httpCookie = request.Definition.Headers.GetItem(i);

                var cookie = new Cookie
                {
                    Name = httpCookie.Name,
                    Value = httpCookie.Value,
                    Domain = request.NetworkClient.RequestUri.Host
                };

                request.NetworkClient.CookieContainer.Add(cookie);
            }
        }

        private void CopyHeaders(Root.Code.Models.E01D.Net.Http.Web.HttpWebRequest request)
        {
            for (int i = 0; i < request.Definition.Headers.Count; i++)
            {
                var header = request.Definition.Headers.GetItem(i);

                if (request.Definition.ControlledHeaders.ContainsKey(header.Name))
                {
                    request.Definition.ControlledHeaders.GetValue(header.Name).Invoke(request, header.Value);
                }
                else
                {
                    request.NetworkClient.Headers.Add(header.Name, header.Value);
                }
            }
        }


        private void CopyNonCategorizedProperties(Root.Code.Models.E01D.Net.Http.Web.HttpWebRequest request)
        {
            request.NetworkClient.AllowAutoRedirect = request.Definition.AllowAutoRedirect;

            if (request.Definition.CachePolicy != null)
            {
                request.NetworkClient.CachePolicy = request.Definition.CachePolicy;
            }

            if (request.Definition.ClientCertificates != null)
            {
                request.NetworkClient.ClientCertificates = request.Definition.ClientCertificates;
            }

            // By default set all values.
            request.NetworkClient.AutomaticDecompression = request.Definition.AutomaticDecompression;

            request.NetworkClient.ServicePoint.Expect100Continue = request.Definition.Expect100Continue;

            // only set if allow auto redirects set to true and there is a maximum set.  Do not override the maximum value.
            if (request.Definition.AllowAutoRedirect && request.Definition.MaximumAutomaticRedirections.HasValue)
            {
                request.NetworkClient.MaximumAutomaticRedirections = request.Definition.MaximumAutomaticRedirections.Value;
            }

            if (request.Definition.Proxy != null)
            {
                request.NetworkClient.Proxy = request.Definition.Proxy;
            }

            if (!string.IsNullOrWhiteSpace(request.Definition.UserAgent))
            {
                request.NetworkClient.UserAgent = request.Definition.UserAgent;
            }
        }

        private void CopyTimeouts(Root.Code.Models.E01D.Net.Http.Web.HttpWebRequest request)
        {
            if (request.Definition.ReadWriteTimeout.HasValue)
            {
                request.NetworkClient.ReadWriteTimeout = request.Definition.ReadWriteTimeout.Value;
            }

            if (request.Definition.Timeout.HasValue)
            {
                request.NetworkClient.Timeout = request.Definition.Timeout.Value;
            }
        }
    }
}
