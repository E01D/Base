using System;
using System.Collections.Generic;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection
{
    public class PropertyBaseApi
    {
        public bool IsVirtual(PropertyInfo propertyInfo)
        {
            XValidation.ArgumentNotNull(propertyInfo, nameof(propertyInfo));

            MethodInfo m = propertyInfo.GetGetMethod(true);
            if (m != null && m.IsVirtual)
            {
                return true;
            }

            m = propertyInfo.GetSetMethod(true);
            if (m != null && m.IsVirtual)
            {
                return true;
            }

            return false;
        }

        public MethodInfo GetBaseDefinition(PropertyInfo propertyInfo)
        {
            XValidation.ArgumentNotNull(propertyInfo, nameof(propertyInfo));

            MethodInfo m = propertyInfo.GetGetMethod(true);
            if (m != null)
            {
                return m.GetBaseDefinition();
            }

            return propertyInfo.GetSetMethod(true)?.GetBaseDefinition();
        }

        public bool IsPublic(PropertyInfo property)
        {
            if (property.GetGetMethod() != null && property.GetGetMethod().IsPublic)
            {
                return true;
            }
            if (property.GetSetMethod() != null && property.GetSetMethod().IsPublic)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the property is an indexed property.
        /// </summary>
        /// <param name="property">The property.</param>
        /// <returns>
        /// 	<c>true</c> if the property is an indexed property; otherwise, <c>false</c>.
        /// </returns>
        public bool IsIndexedProperty(PropertyInfo property)
        {
            XValidation.ArgumentNotNull(property, nameof(property));

            return (property.GetIndexParameters().Length > 0);
        }

        public MethodInfo GetGetMethod(PropertyInfo propertyInfo)
        {
            return propertyInfo.GetGetMethod(false);
        }

        public MethodInfo GetGetMethod(PropertyInfo propertyInfo, bool nonPublic)
        {
            MethodInfo getMethod = propertyInfo.GetMethod;
            if (getMethod != null && (getMethod.IsPublic || nonPublic))
            {
                return getMethod;
            }

            return null;
        }

        public MethodInfo GetSetMethod(PropertyInfo propertyInfo)
        {
            return propertyInfo.GetSetMethod(false);
        }

        public MethodInfo GetSetMethod(PropertyInfo propertyInfo, bool nonPublic)
        {
            MethodInfo setMethod = propertyInfo.SetMethod;
            if (setMethod != null && (setMethod.IsPublic || nonPublic))
            {
                return setMethod;
            }

            return null;
        }
    }
}
