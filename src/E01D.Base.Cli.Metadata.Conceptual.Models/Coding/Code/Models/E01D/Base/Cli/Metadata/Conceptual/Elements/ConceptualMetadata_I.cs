namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements
{
    /// <summary>
    /// Conceptually represents metadata
    /// </summary>
    public interface ConceptualMetadata_I:MetadataBase_I
    {
        /// <summary>
        /// Gets the metadata modifiers that are asociated with this 
        /// </summary>
        MetadataModifier MetadataModifiers { get; }

        /// <summary>
        /// Gets whether this metadata represents a member.
        /// </summary>
        bool IsMember { get; }
    }
}
