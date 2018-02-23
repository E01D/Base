using System.Xml.Linq;

namespace Root.Code.Api.E01D.Core.Xml
{
    public class XElementApi
    {
        public string GetAttributeValue(XElement element, string localName)
        {
            if (element == null) return null;

            foreach (var attribute in element.Attributes())
            {
                if (attribute.Name.LocalName == localName)
                {
                    return attribute.Value;
                }
            }

            return null;
        }

        public string GetElementValue(XElement element, string localName)
        {
            if (element == null) return null;

            foreach (var childElement in element.Elements())
            {
                if (childElement.Name.LocalName == localName)
                {
                    return childElement.Value;
                }
            }

            return null;
        }

        public bool ContainsElement(XElement target, string localName, out XElement output)
        {
            output = null;

            if (target == null)
            {
                
                return false;
            }

            foreach (var element in target.Elements())
            {
                if (element.Name.LocalName != localName) continue;

                output = element;
                return true;
            }

            return false;
        }
    }
}
