using Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl;

namespace Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection
{
    public class AssemblyNameNode : AssemblyNode, AvlNode_I<AssemblyNameNode, string>
    {
        public AssemblyNameNode Left { get; set; }

        public AssemblyNameNode Right { get; set; }

        public int BalanceFactor { get; set; }

        public string Key { get; set; }
    }
}
