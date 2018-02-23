using System;
using System.Linq;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection
{
    public class AttributeApi
    {
        

        

        public T GetAttribute<T>(object attributeProvider) where T : Attribute
        {
            return GetAttribute<T>(attributeProvider, true);
        }

        public T GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
        {
            T[] attributes = GetAttributes<T>(attributeProvider, inherit);

            return attributes?.FirstOrDefault();
        }


        public T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
        {
            Attribute[] a = GetAttributes(attributeProvider, typeof(T), inherit);

            T[] attributes = a as T[];
            if (attributes != null)
            {
                return attributes;
            }

            return a.Cast<T>().ToArray();
        }

        public Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit)
        {
            XValidation.ArgumentNotNull(attributeProvider, nameof(attributeProvider));

            object provider = attributeProvider;

            // http://hyperthink.net/blog/getcustomattributes-gotcha/
            // ICustomAttributeProvider doesn't do inheritance

            Type t = provider as Type;
            if (t != null)
            {
                object[] array = attributeType != null ? t.GetCustomAttributes(attributeType, inherit) : t.GetCustomAttributes(inherit);
                Attribute[] attributes = array.Cast<Attribute>().ToArray();

#if (NET20 || NET35)
                // ye olde .NET GetCustomAttributes doesn't respect the inherit argument
                if (inherit && t.BaseType != null)
                {
                    attributes = attributes.Union(GetAttributes(t.BaseType, attributeType, inherit)).ToArray();
                }
#endif

                return attributes;
            }

            Assembly a = provider as Assembly;
            if (a != null)
            {
                return (attributeType != null) ? Attribute.GetCustomAttributes(a, attributeType) : Attribute.GetCustomAttributes(a);
            }

            MemberInfo mi = provider as MemberInfo;
            if (mi != null)
            {
                return (attributeType != null) ? Attribute.GetCustomAttributes(mi, attributeType, inherit) : Attribute.GetCustomAttributes(mi, inherit);
            }

            Module m = provider as Module;
            if (m != null)
            {
                return (attributeType != null) ? Attribute.GetCustomAttributes(m, attributeType, inherit) : Attribute.GetCustomAttributes(m, inherit);
            }

            ParameterInfo p = provider as ParameterInfo;

            if (p != null)
            {
                return (attributeType != null) ? Attribute.GetCustomAttributes(p, attributeType, inherit) : Attribute.GetCustomAttributes(p, inherit);
            }

#if !PORTABLE40
            ICustomAttributeProvider customAttributeProvider = (ICustomAttributeProvider)attributeProvider;
            object[] result = (attributeType != null) ? customAttributeProvider.GetCustomAttributes(attributeType, inherit) : customAttributeProvider.GetCustomAttributes(inherit);

            return (Attribute[])result;
#else
            throw new Exception("Cannot get attributes from '{0}'.".FormatWith(CultureInfo.InvariantCulture, provider));
#endif
        }
    }
}
