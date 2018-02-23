using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata
{
    public class MetadataBase:Poco, MetadataBase_I
    {
        

        /// <summary>
        /// Gets or sets whether the concept is mapped to a active runtime type.
        /// </summary>
        public bool IsMappedToRuntime { get; set; }

        /// <summary>
        /// Gets or sets the runtime to which this concept is mapped.
        /// </summary>
        public object Runtime { get; set; }

        /// <summary>
        /// Gets or sets the object that came from the runtime that is mapped to this metadata concept.  This can be a method handle, type handle, an assembly or another reflection object.
        /// </summary>
        public object RuntimeMapping { get; set; }
    }
}
