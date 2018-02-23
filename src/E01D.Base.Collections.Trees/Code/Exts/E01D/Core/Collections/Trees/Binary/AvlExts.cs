using System;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.Collections.Trees.Binary.Avl;

namespace Root.Code.Exts.E01D.Core.Collections.Trees.Binary
{
    public static class AvlExts
    {
        public static TNode Find<TNode>(this TNode node, int key)
            where TNode : class, AvlNode_I<TNode, int>
        {
            return XTrees.Api.Avls.Find(node, key);
        }

        public static TNode Find<TNode>(this TNode node, long key)
            where TNode : class, AvlNode_I<TNode, long>
        {
            return XTrees.Api.Avls.Find(node, key);
        }

        public static TNode Find<TNode>(this TNode node, string key)
           where TNode : class, AvlNode_I<TNode, string>
        {
            return XTrees.Api.Avls.Find(node, key);
        }

        public static TNode Find<TNode, TKey>(this TNode node, TKey key, Func<TKey, TKey, long> comparer)
            where TNode : class, AvlNode_I<TNode, TKey>
        {
            return XTrees.Api.Avls.Find(node, key, comparer);
        }

        public static void Iterate<TNode, TKey>(this TNode avlNode, Action<TNode> action) where TNode: class, AvlNode_I<TNode, TKey>, new()
        {
            XTrees.Api.Avls.Iterate<TNode, TKey>(avlNode, action);
        }
    }
}
