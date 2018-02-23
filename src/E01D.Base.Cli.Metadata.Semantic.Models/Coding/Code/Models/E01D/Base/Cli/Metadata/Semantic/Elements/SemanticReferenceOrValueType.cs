namespace Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements
{
    public abstract class SemanticReferenceOrValueType:SemanticNamedType, SemanticReferenceOrValueType_I
    {
        
        public int Arity { get; set; }
        public bool IsGenericType { get; set; }
    }
}
