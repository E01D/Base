using Root.Coding.Code.Api.E01D.Core;

namespace Root.Coding.Code.Api.E01D
{
    public class BaseApi
    {
        public CastingApi Casting { get; set; } = new CastingApi();

        public EnvironmentalApi Environmental { get; set; } = new EnvironmentalApi();


        public PrimitivesApi Primitives { get; set; } = new PrimitivesApi();

        public SemanticVersionApi SemanticVersions { get; set; } = new SemanticVersionApi();


        public VersionApi Versions { get; set; } = new VersionApi();
        public ArrayApi Arrays { get; set; } = new ArrayApi();
    }
}
