using Root.Code.Models.E01D.Configurational;
using System.Collections.Generic;
using Root.Code.Domains.E01D;

namespace Root.Code.Exts.E01D.Configurational
{
    public static class ConfigurationProviderExts
    {
        public static IEnumerable<string> GetChildKeys(this ConfigurationProvider_I configurationProvider, IEnumerable<string> pastKeys, string parentPath)
        {
            return XConfigurational.Api.ConfigurationProviders.GetChildKeys(configurationProvider, pastKeys, parentPath);
        }

        public static void Load(this ConfigurationProvider_I configurationProvider)
        {
            XConfigurational.Api.ConfigurationProviders.Load(configurationProvider);
        }

        public static bool TryGet(this ConfigurationProvider_I configurationProvider, string key, out string value)
        {
            return XConfigurational.Api.ConfigurationProviders.TryGet(configurationProvider, key, out value);
        }

        public static void Set(this ConfigurationProvider_I configurationProvider, string key, string value)
        {
            XConfigurational.Api.ConfigurationProviders.Set(configurationProvider, key, value);
        }

        
    }
}
