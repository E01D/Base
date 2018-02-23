namespace Root.Coding.Code.Models.E01D.Base.Types
{
    /// <summary>
    /// Specifies that the object has a type id associted with it.  Almost all objects that are within the E01D.Base Architecture should have an typeId associated with them.
    /// </summary>
    public interface Typed_I
    {
        /// <summary>
        /// Gets or sets the type id associated with the object.
        /// </summary>
        TypeId_I TypeId { get; set; }
    }
}
