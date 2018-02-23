using System;

namespace Root.Code.Models.E01D.Core.Collections.Hashtables
{
    public struct Bucket
    {
        public Object key;
        public Object val;
        public int hash_coll;   // Store hash code; sign bit means there was a collision.
    }
}
