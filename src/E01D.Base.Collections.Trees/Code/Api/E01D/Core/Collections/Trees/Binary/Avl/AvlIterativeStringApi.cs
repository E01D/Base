using Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl;

namespace Root.Code.Api.E01D.Core.Collections.Trees.Binary.Avl
{
    public class AvlIterativeStringApi : AvlIterativeApi<StringAvlNode, string, string>
    {
        public override long CompareKeys(string x, string y)
        {
            return string.CompareOrdinal(x, y);
        }
    }
}