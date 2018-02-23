using System;
using Root.Code.Models.E01D.Core.Collections.Generic;
using Root.Code.Models.E01D.Net.Http.Web;

namespace Root.Code.Models.E01D.Net.Http
{
    public class HttpContext
    {
        /// <summary>
        /// Gets or sets controlled header  
        /// </summary>
        public Dictionary<string, Action<HttpWebRequest, string>> ControlledHeaders = new Dictionary<string, Action<HttpWebRequest, string>>();
    }
}
