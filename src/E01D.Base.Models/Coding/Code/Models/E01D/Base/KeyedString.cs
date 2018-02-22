namespace Root.Coding.Code.Models.E01D.Base
{
    /// <summary>
    /// Gets or sets string that has been tied to a long identifer.  It makes it faster to get a cache key.
    /// </summary>
    public class KeyedString
    {   
        public long Key { get; set; }

        public string Value { get; set; }
    
    }
}
