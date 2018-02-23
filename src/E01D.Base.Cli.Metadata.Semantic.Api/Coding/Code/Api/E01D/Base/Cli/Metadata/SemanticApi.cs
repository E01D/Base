using Root.Coding.Code.Api.E01D.Base.Cli.Metadata.Semantic;

namespace Root.Coding.Code.Api.E01D.Base.Cli.Metadata
{
    public class SemanticApi
    {
        public ElementApi Elements { get; set; } = new ElementApi();

        public ModelApi Models { get; set; } = new ModelApi();
    }
}
