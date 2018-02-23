namespace Root.Testing.Tests.Models.E01D.Json
{
    public abstract class JsonNodeTests
    {
        /// <summary>
        /// Gets whether this node represents a boolean value.
        /// </summary>
        public abstract bool IsBoolean { get; }

        /// <summary>
        /// Gets whether this node represents an array.
        /// </summary>
        public abstract bool IsArray { get; }

        /// <summary>
        /// Gets whether this node represents a null.
        /// </summary>
        public abstract bool IsNull { get; }

        /// <summary>
        /// Gets whether this node represents a number.
        /// </summary>
        public abstract bool IsNumber { get; }

        /// <summary>
        /// Gets whether this node represents a object.
        /// </summary>
        public abstract bool IsObject { get; }

        /// <summary>
        /// Gets whether this node represents a string.
        /// </summary>
        public abstract bool IsString { get; }

        

        

        

        
    }
}
