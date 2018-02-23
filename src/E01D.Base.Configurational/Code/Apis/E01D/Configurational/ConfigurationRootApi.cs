using System;
using Root.Code.Models.E01D.Configurational;
using Root.Code.Models.E01D.Core.Collections.Generic;

namespace Root.Code.Apis.E01D.Configurational
{
    public class ConfigurationRootApi
    {
        /// <summary>
        /// Creates a new configuration root
        /// </summary>
        /// <param name="providers"></param>
        /// <returns></returns>
        public ConfigurationRoot Create(List_I<ConfigurationProvider_I> providers)
        {
            if (providers == null)
            {
                throw new ArgumentNullException(nameof(providers));
            }

            var root = new ConfigurationRoot()
            {
                Providers = providers
            };

            return root;
        }

        //public string GetProviders(ConfigurationRoot_I configurationRoot, string key)
        //{
        //    foreach (var provider in configurationRoot.Providers.Reverse())
        //    {
        //        string value;

        //        if (provider.TryGet(key, out value))
        //        {
        //            return value;
        //        }
        //    }

        //    return null;
        //}

        //public void SetProviders(ConfigurationRoot_I configurationRoot, string key, string @value)
        //{
        //    var providers = configurationRoot.Providers;

        //    if (!providers.Any())
        //    {
        //        throw new InvalidOperationException("No providers available.");
        //    }

        //    foreach (var provider in providers)
        //    {
        //        provider.Set(key, @value);
        //    }
            
        //}
    }
}
