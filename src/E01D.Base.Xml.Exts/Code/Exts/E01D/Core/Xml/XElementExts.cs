using Root.Code.Domains.E01D;
using System.Xml.Linq;

namespace Root.Code.Exts.E01D.Core.Xml
{
    public static class XElementExts
    {
        public static string GetAttributeValue(this XElement element, string localName)
        {
            return XXml.Api.XElements.GetAttributeValue(element, localName);
        }

        public static string GetElementValue(this XElement element, string localName)
        {
            return XXml.Api.XElements.GetElementValue(element, localName);
        }

        public static bool ContainsElement(this XElement element, string localName, out XElement output)
        {
            return XXml.Api.XElements.ContainsElement(element, localName, out output);
        }
    }
}
