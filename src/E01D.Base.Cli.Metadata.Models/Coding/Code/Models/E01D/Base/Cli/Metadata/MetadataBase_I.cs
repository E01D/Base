using Root.Coding.Code.Models.E01D.Base.Identification;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata
{
    /// <summary>
    /// Represents a CLI metadata concept that can be mapped to a runtime implemenation of that metadata.
    /// </summary>
    public interface MetadataBase_I:Poco_I
    {
        /// <summary>
        /// Gets or sets whether the concept is mapped to a active runtime type.
        /// </summary>
        bool IsMappedToRuntime { get; set; }

        /// <summary>
        /// Gets or sets the runtime to which this concept is mapped.
        /// </summary>
        object Runtime { get; set; }

        /// <summary>
        /// Gets or sets the object that came from the runtime that is mapped to this metadata concept.
        /// </summary>
        object RuntimeMapping { get; set; }
    }
}
