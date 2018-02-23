using System;
using System.Collections.Generic;
using Root.Coding.Code.Api.E01D.Base.Primitives;
using Root.Coding.Code.Api.E01D.Core;
using Root.Coding.Code.Models.E01D.Collections.Standard;
using Root.Coding.Code.Models.E01D.Core;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XEnums
    {
        public static EnumApi Api { get; set; } = new EnumApi();

        public static BidirectionalDictionary<string, string> InitializeEnumType(Type type)
        {
            return Api.InitializeEnumType(type);
        }

        public static EnumValue<T> EnumValue<T>(string name, T value) where T : struct
        {
            return Api.EnumValue(name, value);
        }

        public  static IList<T> GetFlagsValues<T>(T value) where T : struct
        {
            return Api.GetFlagsValues(value);
        }

        /// <summary>
        /// Gets a dictionary of the names and values of an <see cref="Enum"/> type.
        /// </summary>
        /// <returns></returns>
        public static IList<EnumValue<ulong>> GetNamesAndValues<T>() where T : struct
        {
            return Api.GetNamesAndValues<T>();
        }

        /// <summary>
        /// Gets a dictionary of the names and values of an Enum type.
        /// </summary>
        /// <param name="enumType">The enum type to get names and values for.</param>
        /// <returns></returns>
        public static IList<EnumValue<TUnderlyingType>> GetNamesAndValues<TUnderlyingType>(Type enumType) where TUnderlyingType : struct
        {
            return Api.GetNamesAndValues<TUnderlyingType>(enumType);
        }

        public static IList<object> GetValues(Type enumType)
        {
            return Api.GetValues(enumType);
        }

        public static IList<string> GetNames(Type enumType)
        {
            return Api.GetNames(enumType);
        }

        public static object ParseEnumName(string enumText, bool isNullable, bool disallowValue, Type t)
        {
            return Api.ParseEnumName(enumText, isNullable, disallowValue, t);
        }

        public static string ToEnumName(Type enumType, string enumText, bool camelCaseText)
        {
            return Api.ToEnumName(enumType, enumText, camelCaseText);
        }
    }
}
