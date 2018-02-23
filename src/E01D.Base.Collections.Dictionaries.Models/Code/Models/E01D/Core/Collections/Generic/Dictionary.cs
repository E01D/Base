// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*============================================================
**
** 
** 
**
** Purpose: Generic hash table implementation
**
** #DictionaryVersusHashtableThreadSafety
** Hashtable has multiple reader/single writer (MR/SW) thread safety built into 
** certain methods and properties, whereas Dictionary doesn't. If you're 
** converting framework code that formerly used Hashtable to Dictionary, it's
** important to consider whether callers may have taken a dependence on MR/SW
** thread safety. If a reader writer lock is available, then that may be used
** with a Dictionary to get the same thread safety guarantee. 
** 
** Reader writer locks don't exist in silverlight, so we do the following as a
** result of removing non-generic collections from silverlight: 
** 1. If the Hashtable was fully synchronized, then we replace it with a 
**    Dictionary with full locks around reads/writes (same thread safety
**    guarantee).
** 2. Otherwise, the Hashtable has the default MR/SW thread safety behavior, 
**    so we do one of the following on a case-by-case basis:
**    a. If the race condition can be addressed by rearranging the code and using a temp
**       variable (for example, it's only populated immediately after created)
**       then we address the race condition this way and use Dictionary.
**    b. If there's concern about degrading performance with the increased 
**       locking, we ifdef with FEATURE_NONGENERIC_COLLECTIONS so we can at 
**       least use Hashtable in the desktop build, but Dictionary with full 
**       locks in silverlight builds. Note that this is heavier locking than 
**       MR/SW, but this is the only option without rewriting (or adding back)
**       the reader writer lock. 
**    c. If there's no performance concern (e.g. debug-only code) we 
**       consistently replace Hashtable with Dictionary plus full locks to 
**       reduce complexity.
**    d. Most of serialization is dead code in silverlight. Instead of updating
**       those Hashtable occurences in serialization, we carved out references 
**       to serialization such that this code doesn't need to build in 
**       silverlight. 
===========================================================*/


using System;
using System.Collections.Generic;
using System.Diagnostics;
using Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries;
using Root.Coding.Code.Models.E01D.Base.Identification;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Code.Models.E01D.Core.Collections.Generic
{
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public class Dictionary<TKey, TValue>: Dictionary_I
    {
        public int[] Buckets { get; set; }

        public IEqualityComparer<TKey> Comparer { get; set; }

        public int Count { get; set; }

        public DictionaryEntry<TKey, TValue>[] Entries { get; set; }

        public int FreeCount { get; set; }

        public int FreeList { get; set; }

        public KeyCollection<TKey, TValue> Keys { get; set; } = new KeyCollection<TKey, TValue>();
        Collection_I Dictionary_I.Values => Values;
        public bool IsReadOnly => false;
        public bool IsFixedSize => false;

        public Object SyncRoot { get; set; } = new object();

        Collection_I Dictionary_I.Keys => Keys;

        public ValueCollection<TKey, TValue> Values { get; set; } = new ValueCollection<TKey, TValue>();

        public int Version { get; set; }

        /// <summary>
        /// Gets or sets the type id associated with the collection.  
        /// </summary>
        /// <remarks>
        /// Being this is a collection, it is not guarenteed that this will be set during creation, as type and identifier processes can consume collections.  
        /// </remarks>
        public TypeId_I TypeId { get; set; }

        /// <summary>
        /// Gets or sets the id associated with the collection.  
        /// </summary>
        /// <remarks>
        /// Being this is a collection, it is not guarenteed that this will be set during creation, as type and identifier processes can consume dictionaries.  
        /// </remarks>
        public Id_I Id { get; set; }
    }
}