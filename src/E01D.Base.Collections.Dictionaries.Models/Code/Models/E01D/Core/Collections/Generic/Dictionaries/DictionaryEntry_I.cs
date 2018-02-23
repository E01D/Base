namespace Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries
{
    public interface DictionaryEntry_I
    {
        int HashCode { get; }    // Lower 31 bits of hash code, -1 if unused
        int Next { get; }        // Index of next entry, -1 if last
        object Key { get; }          // Key of entry
        object Value { get; }         // Value of entry
    }
}
