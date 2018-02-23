using Root.Coding.Code.Api.E01D.Core;
using Root.Coding.Code.Models.E01D.Core.Objectal;

namespace Root.Coding.Code.Domains
{
    public static class XObjectal
    {
        /// <summary>
        /// Gets or sets the 
        /// </summary>
        public static ObjectalApi Api { get; set; } = new ObjectalApi();

        /// <summary>
        /// Gets or sets the global container state
        /// </summary>
        public static ObjectContainer Container { get; set; }
    }
}
