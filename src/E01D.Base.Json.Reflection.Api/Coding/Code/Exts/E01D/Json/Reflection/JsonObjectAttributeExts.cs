using Root.Coding.Code.Attributes.E01D.Json.Reflection;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Enums.E01D.Json.Reflection;

namespace Root.Coding.Code.Exts.E01D.Json.Reflection
{
    public static class JsonObjectAttributeExts
    {
        /// <summary>
        /// Gets or sets the member serialization.
        /// </summary>
        /// <value>The member serialization.</value>
        public static MemberSerialization MemberSerialization(this JsonObjectAttribute attribute)
        {
            return XJsonReflection.Api.ObjectAttributes.MemberSerialization(attribute);
        }

        /// <summary>
        /// Gets or sets the member serialization.
        /// </summary>
        /// <value>The member serialization.</value>
        public static void MemberSerialization(this JsonObjectAttribute attribute, MemberSerialization value)
        {
            XJsonReflection.Api.ObjectAttributes.MemberSerialization(attribute, value);
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the object's properties are required.
        /// </summary>
        /// <value>
        /// 	A value indicating whether the object's properties are required.
        /// </value>
        public static Required ItemRequired(this JsonObjectAttribute attribute)
        {
            return XJsonReflection.Api.ObjectAttributes.ItemRequired(attribute);
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the object's properties are required.
        /// </summary>
        /// <value>
        /// 	A value indicating whether the object's properties are required.
        /// </value>
        public static void ItemRequired(JsonObjectAttribute attribute, Required value)
        {
            XJsonReflection.Api.ObjectAttributes.ItemRequired(attribute, value);
        }
    }
}
