using Root.Coding.Code.Enums.E01D.Rest;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest
{
    /// <summary>
    /// Represents part of a rest call
    /// </summary>
    public abstract class RestRequestComponent
    {
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the rest call component
        /// </summary>
        public CallComponentType Type { get; set; }
    }
}
