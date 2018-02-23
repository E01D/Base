using System.IO;
using System.Xml.Linq;
using Root.Code.Api.E01D.Core;
using Root.Code.Models.E01D.Core.Xml;

namespace Root.Code.Domains.E01D
{
    public static class XXml
    {
        public static XmlApi Api { get; set; } = new XmlApi();

        public static bool IsNullOrWhiteSpace(XmlString xml)
        {
            return Api.IsNullOrWhiteSpace(xml);
        }

        public static XDocument Parse(XmlString xml)
        {
            return Api.Parse(xml);
        }

        public static XmlString ReadToEnd(Stream stream)
        {
            return Api.ReadToEnd(stream);
        }
    }
}
