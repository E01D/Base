using System;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Security.Authentication
{
    public class Token:Poco, Token_I
    {
        /// <summary>
        /// Gets or sets the raw token content
        /// </summary>
        public string RawContent { get; set; }

        /// <summary>
        /// Gets or sets the time when the token expires.
        /// </summary>
        public DateTime Expires { get; set; }
    }
}
