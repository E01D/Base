namespace Root.Coding.Code.Enums.E01D.Json
{
    public enum JsonReadMode
    {
        Unknown = 0,
        /// <summary>
        /// A <see cref="JsonReader"/> read method has not been called.
        /// </summary>
        Start,

        /// <summary>
        /// The end of the file has been reached successfully.
        /// </summary>
        Complete,

        /// <summary>
        /// Reader is at a property.
        /// </summary>
        Property,

        /// <summary>
        /// Reader is at the start of an object.
        /// </summary>
        ObjectStart,

        /// <summary>
        /// Reader is in an object.
        /// </summary>
        Object,

        /// <summary>
        /// Reader is at the start of an array.
        /// </summary>
        ArrayStart,

        /// <summary>
        /// Reader is in an array.
        /// </summary>
        Array,

        /// <summary>
        /// The <see cref="JsonReader.Close()"/> method has been called.
        /// </summary>
        Closed,

        /// <summary>
        /// Reader has just read a value.
        /// </summary>
        PostValue,

        /// <summary>
        /// Reader is at the start of a constructor.
        /// </summary>
        ConstructorStart,

        /// <summary>
        /// Reader is in a constructor.
        /// </summary>
        Constructor,

        /// <summary>
        /// An error occurred that prevents the read operation from continuing.
        /// </summary>
        Error,

        /// <summary>
        /// The end of the file has been reached successfully.
        /// </summary>
        Finished
    }
}
