using Root.Coding.Code.Api.E01D.Base.Textual.TextSources;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Base.Textual;
using Root.Coding.Code.Models.E01D.Base.Textual;

namespace Root.Coding.Code.Api.E01D.Base.Textual
{
    public class TextSourceApi
    {
        /// <summary>
        /// Gets or sets the file text source api
        /// </summary>
        public FileApi Files { get; set; } = new FileApi();

        /// <summary>
        /// Gets or sets the stream text source api
        /// </summary>
        public StreamApi Streams { get; set; } = new StreamApi();

        /// <summary>
        /// Gets or sets the string text source api
        /// </summary>
        public StringApi Strings { get; set; } = new StringApi();

        /// <summary>
        /// Gets the value of the text source.
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public string GetValue(TextSegment_I segment)
        {
            var source = segment.Source;

            string result;

            switch (source.Type)
            {
                case TextSourceType.File:
                {
                        result = XTextual.TextSources.Files.GetValue(segment, (TextSourceFile)source);
                        break;
                    }
                case TextSourceType.Stream:
                {
                        result = XTextual.TextSources.Streams.GetValue(segment, (TextSourceStream)source);
                        break;
                }
                case TextSourceType.String:
                {
                        result =  XTextual.TextSources.Strings.GetValue(segment, (TextSourceString)source);
                        break;
                    }
                default:
                {
                    throw XExceptions.Exception("TextSourceType is not supported.");
                }
            }

            if (segment.SupportsCachedValue)
            {
                segment.CachedValue = result;
            }

            return result;
        }
    }
}
