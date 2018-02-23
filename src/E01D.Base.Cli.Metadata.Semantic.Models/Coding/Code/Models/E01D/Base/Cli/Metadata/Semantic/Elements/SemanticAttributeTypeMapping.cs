namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public class SemanticAttributeTypeMapping
    {
        /// <summary>
        /// Gets or sets the class associated with the attribute.
        /// </summary>
        public SemanticClass AttributeClass { get; set; }

        /// <summary>
        /// Gets or sets the type marked with the attirbute.
        /// </summary>
        public SemanticType_I ImplementingType { get; set; }

        /// <summary>
        /// Gets or sets the attribute instance associated with the class.
        /// </summary>
        public object Instance { get; set; }
    }
}
