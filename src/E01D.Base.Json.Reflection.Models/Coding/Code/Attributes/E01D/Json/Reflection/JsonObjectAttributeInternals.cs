using Root.Coding.Code.Enums.E01D.Json.Reflection;

namespace Root.Coding.Code.Attributes.E01D.Json.Reflection
{
    public class JsonObjectAttributeInternals: JsonContainerAttributeInternals
    {
        public MemberSerialization MemberSerialization = MemberSerialization.OptOut;

        // yuck. can't set nullable properties on an attribute in C#
        // have to use this approach to get an unset default state
        public Required? ItemRequired { get; set; }


    }
}
