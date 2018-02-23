using System.IO;
using System.Xml.Linq;
using Root.Code.Api.E01D.Core.Xml;
using Root.Code.Models.E01D.Core.Xml;

namespace Root.Code.Api.E01D.Core
{
    public class XmlApi
    {
        public XElementApi XElements { get; set; } = new XElementApi();

        public bool IsNullOrWhiteSpace(XmlString xml)
        {
            return string.IsNullOrWhiteSpace(xml?.Value);
        }

        public XDocument Parse(XmlString xml)
        {
            return XDocument.Parse(xml.Value);
        }

        public XmlString ReadToEnd(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                return XmlString(reader.ReadToEnd());
            }
        }

        public XmlString XmlString(string value)
        {
            return new XmlString()
            {
                Value = value
            };
        }
    }
}
