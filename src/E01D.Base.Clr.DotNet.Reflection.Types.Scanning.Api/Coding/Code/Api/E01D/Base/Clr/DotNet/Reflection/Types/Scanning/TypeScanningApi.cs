using Root.Coding.Code.Exts.E01D.Base.Cli.Metadata.Semantic;
using Root.Coding.Code.Framework.E01D.Typing;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Elements;
using Root.Coding.Code.Models.E01D.Base.Cli.Metadata.Semantic.Models;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.Types.Scanning
{
    public class TypeScanningApi
    {
        private readonly System.Type _CategorizeAttributeType = typeof(CategorizeAttribute);

        public void ScanType(SemanticModel semanticModel, System.Type type)
        {
            SemanticType_I typeSymbol = semanticModel.GetOrCreateElement(type);

            if (typeSymbol == null) return; 
        }     
    }
}
