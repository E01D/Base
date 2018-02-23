namespace Root.Coding.Code.Models.E01D.Base.Types
{
    /// <summary>
    /// Used to specify the default internal type id value for classes that have a default value.  This saves on lookup speed and provides a base case for internal types.
    /// </summary>
    public interface InternalType_I
    {
        long TypeIdValue { get; }
    }
}
