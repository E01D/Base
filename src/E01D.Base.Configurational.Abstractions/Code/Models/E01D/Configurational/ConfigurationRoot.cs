

using Root.Code.Models.E01D.Core.Collections.Generic;

namespace Root.Code.Models.E01D.Configurational
{
    public class ConfigurationRoot: ConfigurationRoot_I
    {
        /// <summary>
        /// Gets or sets the list of providers associated with this configuration 
        /// </summary>
        public List_I<ConfigurationProvider_I> Providers { get; set; }
    }
}
