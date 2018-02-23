using Root.Coding.Code.Enums.E01D.Json;

namespace Root.Coding.Code.Models.E01D.Json
{
    public abstract class JsonNode
    {
        /// <summary>
        /// Gets whether this node represents an array.
        /// </summary>
        public abstract bool IsArray { get; }

        /// <summary>
        /// Gets whether this node represents a boolean value.
        /// </summary>
        public abstract bool IsBoolean { get; }


        public abstract bool IsLazyCreator { get; }

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

        /// <summary>
        /// Gets or sets the string value of the node
        /// </summary>
        public string Value { get; set; }

        public abstract JsonNodeType NodeType { get; }






    }
}
