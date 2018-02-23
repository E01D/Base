using System.Net;
using Root.Code.Api.E01D.Net.Http.Requests;
using Root.Coding.Code.Domains.E01D;
using Exception = System.Exception;

namespace Root.Code.Api.E01D.Net.Http
{
    public class HttpRequestApi
    {
        public CopyingApi Copying { get; set; } = new CopyingApi();

        public Root.Code.Models.E01D.Net.Http.Web.HttpWebResponse Invoke(Root.Code.Models.E01D.Net.Http.Web.HttpWebRequest request)
        {
            var response = new Root.Code.Models.E01D.Net.Http.Web.HttpWebResponse()
            {
                Request = request
            };

            // Create the web request
            request.NetworkClient = (System.Net.HttpWebRequest)WebRequest.Create(request.Definition.FullUrl);

            Copying.CopyToWebRequest(request);

            try
            {
                InvokeInternal(response);
            }
            catch (Exception e)
            {
                XLog.LogException(e);
                // Core.Logging.LogException( // needs to be a domain level context, the system context, that contains log sinks
                //EvoRest.Rest.Logging.LogException(response, e);
            }

            return response;
        }

        

        public void InvokeInternal(Root.Code.Models.E01D.Net.Http.Web.HttpWebResponse response)
        {
            try
            {
                response.NetworkResponse = (System.Net.HttpWebResponse)response?.Request?.NetworkClient?.GetResponse();
            }
            catch (WebException e)
            {
                response.NetworkResponse = e.Response as System.Net.HttpWebResponse;

                throw;
            }
        }
    }
}
