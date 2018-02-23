using Root.Code.Models.E01D.Core.Collections.Generic;

namespace Root.Code.Models.E01D.Configurational
{
    public interface ConfigurationRoot_I
    {
        List_I<ConfigurationProvider_I> Providers { get; set; }
    }
}
