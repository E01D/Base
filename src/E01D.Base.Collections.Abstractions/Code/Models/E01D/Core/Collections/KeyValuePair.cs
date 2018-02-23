using System.Diagnostics;

namespace Root.Code.Models.E01D.Core.Collections
{
    [DebuggerDisplay("{_Value}", Name = "[{_Key}]")]
    public class KeyValuePair : KeyValuePair_I
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly object _Key;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly object _Value;

        public KeyValuePair(object key, object value)
        {
            _Key = key;
            _Value = value;
        }

        /// <summary>
        /// Gets or sets the value of the key value pair
        /// </summary>
        public object Key => _Key;

        /// <summary>
        /// Gets or sets the value of the key value pair
        /// </summary>
        public object Value => _Value;
    }

    [DebuggerDisplay("{_Value}", Name = "[{_Key}]")]
    public class KeyValuePair<TKey, TValue>: KeyValuePair_I
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly TKey _Key;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly TValue _Value;

        public KeyValuePair()
        {
            
        }

        public KeyValuePair(TKey key, TValue value)
        {
            _Key = key;
            _Value = value;
        }

        public TKey Key => _Key;

        public TValue Value => _Value;

        object KeyValuePair_I.Key => Key;

        object KeyValuePair_I.Value => Value;
    }
}
