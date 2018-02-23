using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Exceptions;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic
{
    public class SemanticMetadataExceptionApi
    {
        public MissingElementException MissingElement()
        {
            return new MissingElementException();
        }
    }
}
