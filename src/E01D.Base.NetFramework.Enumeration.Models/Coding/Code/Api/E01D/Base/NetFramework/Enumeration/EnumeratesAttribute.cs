namespace Root.Coding.Code.Api.E01D.Base.NetFramework.Enumeration
{
    public class EnumeratesAttribute:System.Attribute
    {


        public EnumeratesAttribute(System.Type itemType)
        {
            ItemType = itemType;
        }

        public System.Type ItemType { get; set; }
    }
}
