using Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Exceptions;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XSemanticMetadataExceptions
    {
        public static SemanticMetadataExceptionApi Api { get; set; } = new SemanticMetadataExceptionApi();

        public static MissingElementException MissingElement()
        {
            return Api.MissingElement();
        }
    }
}
