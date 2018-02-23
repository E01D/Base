using System;
using System.Collections.Generic;
using Root.Code.Models.E01D.Configurational;

namespace Root.Code.Apis.E01D.Configurational
{
    public class ConfigurationProviderApi
    {
        public void Load(ConfigurationProvider_I configurationProvider)
        {
            
        }

        public void Set(ConfigurationProvider_I configurationProvider, string key, string value)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<string> GetChildKeys(ConfigurationProvider_I configurationProvider, IEnumerable<string> pastKeys, string parentPath)
        {
            throw new NotImplementedException();
        }

        public bool TryGet(ConfigurationProvider_I configurationProvider, string key, out string value)
        {
            throw new NotImplementedException();
        }
    }
}
