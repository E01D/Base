using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Collections.Standard;

namespace Root.Coding.Code.Exts.E01D.Collections.Standard
{
    public static class BidirectionalDictionaryExts
    {
        public static void Set<TFirst, TSecond>(this BidirectionalDictionary<TFirst, TSecond> dictionary, TFirst first, TSecond second)
        {
            XStandardCollections.Api.BidirectionalDictionaries.Set(dictionary, first, second);
        }

        public static bool TryGetByFirst<TFirst, TSecond>(this BidirectionalDictionary<TFirst, TSecond> dictionary, TFirst first, out TSecond second)
        {
            return XStandardCollections.Api.BidirectionalDictionaries.TryGetByFirst(dictionary, first, out second);
        }

        public static bool TryGetBySecond<TFirst, TSecond>(this BidirectionalDictionary<TFirst, TSecond> dictionary, TSecond second, out TFirst first)
        {
            return XStandardCollections.Api.BidirectionalDictionaries.TryGetBySecond(dictionary, second, out first);
        }
    }
}
