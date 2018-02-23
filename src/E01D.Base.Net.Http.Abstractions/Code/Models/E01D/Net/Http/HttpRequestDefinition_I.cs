using System;
using Root.Code.Enums.E01D.Net.Http;

namespace Root.Code.Models.E01D.Net.Http
{
    public interface HttpRequestDefinition_I
    {
        /// <summary>
        /// Gets the name of the server you want to contact.  E.g. http://api.somesite.com
        /// </summary>
        Uri Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the resource at that end 
        /// </summary>
        string Resource { get; set; }

        HttpMethodType MethodType { get; set; }
    }
}
