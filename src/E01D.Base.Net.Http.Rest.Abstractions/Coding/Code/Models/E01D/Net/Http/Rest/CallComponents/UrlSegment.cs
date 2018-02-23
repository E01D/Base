namespace Root.Coding.Code.Models.E01D.Net.Http.Rest.CallComponents
{
    public class UrlSegment:RestRequestComponent
    {
        public UrlSegment()
        {
            Type = global::Root.Coding.Code.Enums.E01D.Rest.CallComponentType.UrlSegment;
        }

        /// <summary>
        /// Gets or sets the name of the url segment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the url segment
        /// </summary>
        public string Value { get; set; }

    }
}
