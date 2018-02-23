using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection.Serialization.NamingStrategies;

namespace Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection
{
    public static class DefaultNamingStrategyExts
    {
        /// <summary>
        /// Gets the serialized name for a given property name.
        /// </summary>
        /// <param name="name">The initial property name.</param>
        /// <param name="hasSpecifiedName">A flag indicating whether the property has had a name explicitly specified.</param>
        /// <returns>The serialized property name.</returns>
        public static string GetPropertyName(this NamingStrategy namingStrategy, string name, bool hasSpecifiedName)
        {
            return XReflectionBase.Api.Serialization.NamingStrategies.GetPropertyName(namingStrategy, name, hasSpecifiedName);
        }

        /// <summary>
        /// Gets the serialized name for a given extension data name.
        /// </summary>
        /// <param name="name">The initial extension data name.</param>
        /// <returns>The serialized extension data name.</returns>
        public static string GetExtensionDataName(this NamingStrategy namingStrategy, string name)
        {
            return XReflectionBase.Api.Serialization.NamingStrategies.GetExtensionDataName(namingStrategy, name);
        }

        /// <summary>
        /// Gets the serialized key for a given dictionary key.
        /// </summary>
        /// <param name="key">The initial dictionary key.</param>
        /// <returns>The serialized dictionary key.</returns>
        public static string GetDictionaryKey(this NamingStrategy namingStrategy, string key)
        {
            return XReflectionBase.Api.Serialization.NamingStrategies.GetExtensionDataName(namingStrategy, key);
        }

        /// <summary>
        /// Resolves the specified property name.
        /// </summary>
        /// <param name="name">The property name to resolve.</param>
        /// <returns>The resolved property name.</returns>
        public static string ResolvePropertyName(this NamingStrategy namingStrategy, string name)
        {
            return XReflectionBase.Api.Serialization.NamingStrategies.ResolvePropertyName(namingStrategy, name);
        }
    }
}
