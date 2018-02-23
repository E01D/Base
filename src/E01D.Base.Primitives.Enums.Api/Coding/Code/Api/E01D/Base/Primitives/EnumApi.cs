using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Exts.E01D.Collections.Standard;
using Root.Coding.Code.Exts.E01D.Core.Collections.ThreadSafe;
using Root.Coding.Code.Exts.E01D.Strings;
using Root.Coding.Code.Models.E01D.Collections.Standard;
using Root.Coding.Code.Models.E01D.Core;
using Root.Coding.Code.Models.E01D.Core.Collections.ThreadSafe;

namespace Root.Coding.Code.Api.E01D.Base.Primitives
{
    public class EnumApi
    {
        private readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType;


        public EnumApi()
        {
            EnumMemberNamesPerType = XThreadSafe.ThreadSafeStore<Type, BidirectionalDictionary<string, string>>(InitializeEnumType);
        }

        public EnumValue<T> EnumValue<T>(string name, T value) where T : struct
        {
            return new EnumValue<T>()
            {
                Name = name,
                Value = value
            };
        }

        public BidirectionalDictionary<string, string> InitializeEnumType(Type type)
        {
            BidirectionalDictionary<string, string> map = XStandardCollections.Api.BidirectionalDictionaries.New<string, string>(StringComparer.Ordinal,StringComparer.Ordinal);

            foreach (FieldInfo f in type.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                string n1 = f.Name;
                string n2;

#if HAVE_DATA_CONTRACTS
                n2 = f.GetCustomAttributes(typeof(EnumMemberAttribute), true)
                    .Cast<EnumMemberAttribute>()
                    .Select(a => a.Value)
                    .SingleOrDefault() ?? f.Name;
#else
                n2 = f.Name;
#endif

                string s;
                if (map.TryGetBySecond(n2, out s))
                {
                    throw new InvalidOperationException("Enum name '{0}' already exists on enum '{1}'.".FormatWith(CultureInfo.InvariantCulture, n2, type.Name));
                }

                map.Set(n1, n2);
            }

            return map;
        }

        public IList<T> GetFlagsValues<T>(T value) where T : struct
        {
            Type enumType = typeof(T);

            if (!enumType.IsDefined(typeof(FlagsAttribute), false))
            {
                throw new ArgumentException("Enum type {0} is not a set of flags.".FormatWith(CultureInfo.InvariantCulture, enumType));
            }

            Type underlyingType = Enum.GetUnderlyingType(value.GetType());

            ulong num = Convert.ToUInt64(value, CultureInfo.InvariantCulture);
            IList<EnumValue<ulong>> enumNameValues = GetNamesAndValues<T>();
            IList<T> selectedFlagsValues = new List<T>();

            foreach (EnumValue<ulong> enumNameValue in enumNameValues)
            {
                if ((num & enumNameValue.Value) == enumNameValue.Value && enumNameValue.Value != 0)
                {
                    selectedFlagsValues.Add((T)Convert.ChangeType(enumNameValue.Value, underlyingType, CultureInfo.CurrentCulture));
                }
            }

            if (selectedFlagsValues.Count == 0 && enumNameValues.SingleOrDefault(v => v.Value == 0) != null)
            {
                selectedFlagsValues.Add(default(T));
            }

            return selectedFlagsValues;
        }

        /// <summary>
        /// Gets a dictionary of the names and values of an <see cref="Enum"/> type.
        /// </summary>
        /// <returns></returns>
        public IList<EnumValue<ulong>> GetNamesAndValues<T>() where T : struct
        {
            return GetNamesAndValues<ulong>(typeof(T));
        }

        /// <summary>
        /// Gets a dictionary of the names and values of an Enum type.
        /// </summary>
        /// <param name="enumType">The enum type to get names and values for.</param>
        /// <returns></returns>
        public IList<EnumValue<TUnderlyingType>> GetNamesAndValues<TUnderlyingType>(Type enumType) where TUnderlyingType : struct
        {
            if (enumType == null)
            {
                throw new ArgumentNullException(nameof(enumType));
            }

            if (!enumType.IsEnum)
            {
                throw new ArgumentException("Type {0} is not an enum.".FormatWith(CultureInfo.InvariantCulture, enumType.Name), nameof(enumType));
            }

            IList<object> enumValues = GetValues(enumType);
            IList<string> enumNames = GetNames(enumType);

            IList<EnumValue<TUnderlyingType>> nameValues = new List<EnumValue<TUnderlyingType>>();

            for (int i = 0; i < enumValues.Count; i++)
            {
                try
                {
                    nameValues.Add(XEnums.EnumValue<TUnderlyingType>(enumNames[i], (TUnderlyingType)Convert.ChangeType(enumValues[i], typeof(TUnderlyingType), CultureInfo.CurrentCulture)));
                }
                catch (OverflowException e)
                {
                    throw new InvalidOperationException(
                        "Value from enum with the underlying type of {0} cannot be added to dictionary with a value type of {1}. Value was too large: {2}".FormatWith(CultureInfo.InvariantCulture,
                            Enum.GetUnderlyingType(enumType), typeof(TUnderlyingType), Convert.ToUInt64(enumValues[i], CultureInfo.InvariantCulture)), e);
                }
            }

            return nameValues;
        }

        public IList<object> GetValues(Type enumType)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("Type {0} is not an enum.".FormatWith(CultureInfo.InvariantCulture, enumType.Name), nameof(enumType));
            }

            List<object> values = new List<object>();

            foreach (FieldInfo field in enumType.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                object value = field.GetValue(enumType);
                values.Add(value);
            }

            return values;
        }

        public IList<string> GetNames(Type enumType)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("Type {0} is not an enum.".FormatWith(CultureInfo.InvariantCulture, enumType.Name), nameof(enumType));
            }

            List<string> values = new List<string>();

            foreach (FieldInfo field in enumType.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                values.Add(field.Name);
            }

            return values;
        }

        public object ParseEnumName(string enumText, bool isNullable, bool disallowValue, Type t)
        {
            if (enumText == String.Empty && isNullable)
            {
                return null;
            }

            string finalEnumText;

            BidirectionalDictionary<string, string> map = EnumMemberNamesPerType.Get(t);
            string resolvedEnumName;
            if (TryResolvedEnumName(map, enumText, out resolvedEnumName))
            {
                finalEnumText = resolvedEnumName;
            }
            else if (enumText.IndexOf(',') != -1)
            {
                string[] names = enumText.Split(',');
                for (int i = 0; i < names.Length; i++)
                {
                    string name = names[i].Trim();

                    names[i] = TryResolvedEnumName(map, name, out resolvedEnumName)
                        ? resolvedEnumName
                        : name;
                }

                finalEnumText = String.Join(", ", names);
            }
            else
            {
                finalEnumText = enumText;

                if (disallowValue)
                {
                    bool isNumber = Int32.TryParse(finalEnumText, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out int _);

                    if (isNumber)
                    {
                        throw new FormatException("Integer string '{0}' is not allowed.".FormatWith(CultureInfo.InvariantCulture, enumText));
                    }
                }
            }

            return Enum.Parse(t, finalEnumText, true);
        }

        public string ToEnumName(Type enumType, string enumText, bool camelCaseText)
        {
            BidirectionalDictionary<string, string> map = EnumMemberNamesPerType.Get(enumType);

            string[] names = enumText.Split(',');
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].Trim();

                string resolvedEnumName;
                map.TryGetByFirst(name, out resolvedEnumName);
                resolvedEnumName = resolvedEnumName ?? name;

                if (camelCaseText)
                {
                    resolvedEnumName = XStrings.ToCamelCase(resolvedEnumName);
                }

                names[i] = resolvedEnumName;
            }

            string finalName = String.Join(", ", names);

            return finalName;
        }

        private bool TryResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText, out string resolvedEnumName)
        {
            if (map.TryGetBySecond(enumText, out resolvedEnumName))
            {
                return true;
            }

            resolvedEnumName = null;
            return false;
        }
    }
}
