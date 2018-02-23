using System.Collections.Generic;
using System.Linq;
using Root.Coding.Code.Models.E01D.Base.Collections.DoubleDictionaries;

namespace Root.Coding.Code.Api.E01D.Base.Collections.DoubleDictionaries
{
    public abstract class DoubleDictionary<TId, TKey, T>: DoubleDictionary_I<TId, TKey, T>
    {
        public Dictionary<TId, T> NodesById { get; set; } = new Dictionary<TId, T>();
        public Dictionary<TKey, T> NodesByUri { get; set; } = new Dictionary<TKey, T>();

        
    }
}
