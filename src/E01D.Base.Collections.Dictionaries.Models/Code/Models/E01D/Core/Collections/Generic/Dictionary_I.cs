using Root.Coding.Code.Models.E01D.Base.Identification;

namespace Root.Code.Models.E01D.Core.Collections.Generic
{
    public interface Dictionary_I:Ided_I
    {
        int Count { get; set; }

        // Returns a collections of the keys in this dictionary.
        Collection_I Keys
        {
            get;
        }

        // Returns a collections of the values in this dictionary.
        Collection_I Values
        {
            get;
        }

        bool IsReadOnly { get; }

        bool IsFixedSize { get; }

        
    }
}
