using Root.Coding.Code.Enums.E01D.Reflection.Serialization;

namespace Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection.Serialization.NamingStrategies
{
    public abstract class NamingStrategy
    {
        /// <summary>
        /// A flag indicating whether dictionary keys should be processed.
        /// Defaults to <c>false</c>.
        /// </summary>
        public bool ProcessDictionaryKeys { get; set; }

        /// <summary>
        /// A flag indicating whether extension data names should be processed.
        /// Defaults to <c>false</c>.
        /// </summary>
        public bool ProcessExtensionDataNames { get; set; }

        /// <summary>
        /// A flag indicating whether explicitly specified property names,
        /// e.g. a property name customized with a <see cref="JsonPropertyAttribute"/>, should be processed.
        /// Defaults to <c>false</c>.
        /// </summary>
        public bool OverrideSpecifiedNames { get; set; }

        public abstract NamingStrategyKind Kind { get; }
    }
}
