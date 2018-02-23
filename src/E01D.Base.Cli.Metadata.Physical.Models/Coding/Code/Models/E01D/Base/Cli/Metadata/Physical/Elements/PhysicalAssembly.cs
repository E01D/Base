using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Conceptual.Elements;

namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Physical.Elements
{
    public class PhysicalAssembly: PhysicalMetadata, ConceptualAssembly_I
    {
        
        public bool IsMember => false;
    }
}
