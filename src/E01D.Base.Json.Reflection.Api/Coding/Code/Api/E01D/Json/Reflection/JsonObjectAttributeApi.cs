using Root.Coding.Code.Attributes.E01D.Json.Reflection;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Json.Reflection;

namespace Root.Coding.Code.Api.E01D.Json.Reflection
{
    public class JsonObjectAttributeApi
    {
        public JsonObjectAttribute New()
        {
            return new JsonObjectAttribute();
        }

        public JsonObjectAttribute New(MemberSerialization memberSerialization)
        {
            var x =  new Attributes.E01D.Json.Reflection.JsonObjectAttribute();

            x.Internals.MemberSerialization = memberSerialization;

            return x;
        }

        public JsonObjectAttribute New(string id)
        {
            JsonObjectAttribute objectAttribute = new JsonObjectAttribute();

            XJsonReflection.Api.ContainerAttributes.New(objectAttribute, id);

            return objectAttribute;
        }

        public JsonObjectAttributeInternals Internal(JsonObjectAttribute attribute)
        {
            return attribute.Internals;
        }

        public void MemberSerialization(JsonObjectAttribute attribute, MemberSerialization value)
        {
            attribute.Internals.MemberSerialization = value;
        }

        public MemberSerialization MemberSerialization(JsonObjectAttribute attribute)
        {
            return attribute.Internals.MemberSerialization;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the object's properties are required.
        /// </summary>
        /// <value>
        /// 	A value indicating whether the object's properties are required.
        /// </value>
        public Required ItemRequired(JsonObjectAttribute attribute)
        {
            return attribute.Internals.ItemRequired ?? default(Required);

        }

        /// <summary>
        /// Gets or sets a value that indicates whether the object's properties are required.
        /// </summary>
        /// <value>
        /// 	A value indicating whether the object's properties are required.
        /// </value>
        public void ItemRequired(JsonObjectAttribute attribute, Required value)
        {
            attribute.Internals.ItemRequired = value;
        }
    }
}
