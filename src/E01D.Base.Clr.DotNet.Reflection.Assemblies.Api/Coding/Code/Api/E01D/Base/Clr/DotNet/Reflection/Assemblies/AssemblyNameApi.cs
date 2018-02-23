using Root.Code.Api.E01D.Core.Collections.Trees.Binary.Avl;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection.Assemblies
{
    public class AssemblyNameApi : AvlIterativeApi<AssemblyNameNode, string>
    {
        public override long CompareKeys(string x, string y)
        {
            return string.CompareOrdinal(x, y);
        }

        public override void SetValue(AssemblyNameNode existing, AssemblyNameNode newNode)
        {
            newNode.Value = existing.Value;
        }
    }
}
