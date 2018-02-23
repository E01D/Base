using Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection.Serialization.NamingStrategies;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Reflection.Serialization;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection.Serialization.NamingStrategies;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection.Serialization
{
    public class NamingStrategiesApi
    {
        public DefaultNamingStrategyApi Default { get; set; } = new DefaultNamingStrategyApi();

        public CamelCaseNamingStrategyApi CamelCase { get; set; } = new CamelCaseNamingStrategyApi();

        public SnakeCaseNamingStrategyApi SnakeCase { get; set; } = new SnakeCaseNamingStrategyApi();

        /// <summary>
        /// Gets the serialized name for a given property name.
        /// </summary>
        /// <param name="name">The initial property name.</param>
        /// <param name="hasSpecifiedName">A flag indicating whether the property has had a name explicitly specified.</param>
        /// <returns>The serialized property name.</returns>
        public string GetPropertyName(NamingStrategy namingStragegy, string name, bool hasSpecifiedName)
        {
            if (hasSpecifiedName && !namingStragegy.OverrideSpecifiedNames)
            {
                return name;
            }

            return ResolvePropertyName(namingStragegy, name);
        }

        /// <summary>
        /// Gets the serialized name for a given extension data name.
        /// </summary>
        /// <param name="name">The initial extension data name.</param>
        /// <returns>The serialized extension data name.</returns>
        public string GetExtensionDataName(NamingStrategy namingStragegy, string name)
        {
            if (!namingStragegy.ProcessExtensionDataNames)
            {
                return name;
            }

            return ResolvePropertyName(namingStragegy, name);
        }

        /// <summary>
        /// Gets the serialized key for a given dictionary key.
        /// </summary>
        /// <param name="key">The initial dictionary key.</param>
        /// <returns>The serialized dictionary key.</returns>
        public string GetDictionaryKey(NamingStrategy namingStragegy, string key)
        {
            if (!namingStragegy.ProcessDictionaryKeys)
            {
                return key;
            }

            return ResolvePropertyName(namingStragegy, key);
        }

        /// <summary>
        /// Resolves the specified property name.
        /// </summary>
        /// <param name="name">The property name to resolve.</param>
        /// <returns>The resolved property name.</returns>
        public string ResolvePropertyName(NamingStrategy namingStragegy, string name)
        {
            switch (namingStragegy.Kind)
            {
                case NamingStrategyKind.Default:
                {
                    return Default.ResolvePropertyName((DefaultNamingStrategy)namingStragegy, name);
                }
                case NamingStrategyKind.CamelCase:
                {
                    return CamelCase.ResolvePropertyName((CamelCaseNamingStrategy)namingStragegy, name);
                }
                case NamingStrategyKind.SnakeCase:
                {
                    return SnakeCase.ResolvePropertyName((SnakeCaseNamingStrategy)namingStragegy, name);
                }
                default:
                {
                    throw XExceptions.NotSupported.EnumerationValueIsNotValid();
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.E01D.Reflection.Serialization.NamingStrategies.SnakeCaseNamingStrategy"/> class.
        /// </summary>
        /// <param name="processDictionaryKeys">
        /// A flag indicating whether dictionary keys should be processed.
        /// </param>
        /// <param name="overrideSpecifiedNames">
        /// A flag indicating whether explicitly specified property names should be processed,
        /// e.g. a property name customized with a <see cref="JsonPropertyAttribute"/>.
        /// </param>
        public SnakeCaseNamingStrategy SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
        {
            return new SnakeCaseNamingStrategy()
            {
                ProcessDictionaryKeys = processDictionaryKeys,
                OverrideSpecifiedNames = overrideSpecifiedNames,
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.E01D.Reflection.Serialization.NamingStrategies.SnakeCaseNamingStrategy"/> class.
        /// </summary>
        /// <param name="processDictionaryKeys">
        /// A flag indicating whether dictionary keys should be processed.
        /// </param>
        /// <param name="overrideSpecifiedNames">
        /// A flag indicating whether explicitly specified property names should be processed,
        /// e.g. a property name customized with a <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <param name="processExtensionDataNames">
        /// A flag indicating whether extension data names should be processed.
        /// </param>
        public SnakeCaseNamingStrategy SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
        {
            var ns = SnakeCaseNamingStrategy(processDictionaryKeys, overrideSpecifiedNames);

            ns.ProcessExtensionDataNames = processExtensionDataNames;

            return ns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.E01D.Reflection.Serialization.NamingStrategies.SnakeCaseNamingStrategy"/> class.
        /// </summary>
        public SnakeCaseNamingStrategy SnakeCaseNamingStrategy()
        {
            return new SnakeCaseNamingStrategy();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.E01D.Reflection.Serialization.NamingStrategies.CamelCaseNamingStrategy"/> class.
        /// </summary>
        /// <param name="processDictionaryKeys">
        /// A flag indicating whether dictionary keys should be processed.
        /// </param>
        /// <param name="overrideSpecifiedNames">
        /// A flag indicating whether explicitly specified property names should be processed,
        /// e.g. a property name customized with a <see cref="JsonPropertyAttribute"/>.
        /// </param>
        public CamelCaseNamingStrategy CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
        {
            return new CamelCaseNamingStrategy()
            {
                ProcessDictionaryKeys = processDictionaryKeys,
                OverrideSpecifiedNames = overrideSpecifiedNames
            };

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.E01D.Reflection.Serialization.NamingStrategies.CamelCaseNamingStrategy"/> class.
        /// </summary>
        /// <param name="processDictionaryKeys">
        /// A flag indicating whether dictionary keys should be processed.
        /// </param>
        /// <param name="overrideSpecifiedNames">
        /// A flag indicating whether explicitly specified property names should be processed,
        /// e.g. a property name customized with a <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <param name="processExtensionDataNames">
        /// A flag indicating whether extension data names should be processed.
        /// </param>
        public CamelCaseNamingStrategy CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)

        {
            var ns = CamelCaseNamingStrategy(processDictionaryKeys, overrideSpecifiedNames);

            ns.ProcessExtensionDataNames = processExtensionDataNames;

            return ns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.E01D.Reflection.Serialization.NamingStrategies.CamelCaseNamingStrategy"/> class.
        /// </summary>
        public CamelCaseNamingStrategy CamelCaseNamingStrategy()
        {
            return new CamelCaseNamingStrategy();
        }

        
    }
}
