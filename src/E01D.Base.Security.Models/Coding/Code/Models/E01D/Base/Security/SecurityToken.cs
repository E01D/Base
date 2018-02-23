using System;

namespace Root.Coding.Code.Models.E01D.Base.Security
{
    
    public class SecurityToken
    {
        /// <summary>
        /// Gets or sets the raw value of the token.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the time when the token expires.
        /// </summary>
        public DateTime Expires { get; set; }


    }
}
