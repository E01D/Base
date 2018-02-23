using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Models.E01D.Base.Collections.DoubleDictionaries
{
    public interface DoubleDictionary_I<TId, TKey, T>
    {
        Dictionary<TId, T> NodesById { get; set; } 
        Dictionary<TKey, T> NodesByUri { get; set; }
    }
}
