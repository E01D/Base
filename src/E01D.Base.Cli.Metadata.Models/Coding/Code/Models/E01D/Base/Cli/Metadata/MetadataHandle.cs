
using Root.Coding.Code.Models.E01D.Base.Identification;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata
{
    public class MetadataHandle:Ided_I
    {
        /// <summary>
        /// Gets the id value associated with this handle.
        /// </summary>
        public Id_I Id { get; set; }

        /// <summary>
        /// Gets or sets the type id associated with this handle.
        /// </summary>
        public TypeId_I TypeId { get; set; }
    }
}
