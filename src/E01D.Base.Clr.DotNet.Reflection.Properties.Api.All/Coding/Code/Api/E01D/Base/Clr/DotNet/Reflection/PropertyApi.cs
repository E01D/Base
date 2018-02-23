using System;
using System.Collections.Generic;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection;
using Root.Coding.Code.Exts.E01D.Collections;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DotNet.Reflection
{
    public class PropertyApi
    {
        public bool IsVirtual(PropertyInfo propertyInfo)
        {
            return XPropertiesBase.IsVirtual(propertyInfo);
        }

        public MethodInfo GetBaseDefinition(PropertyInfo propertyInfo)
        {
            return XPropertiesBase.GetBaseDefinition(propertyInfo);
        }

        public bool IsPublic(PropertyInfo property)
        {
            return XPropertiesBase.IsPublic(property);
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
            return XPropertiesBase.IsIndexedProperty(property);
        }

        public void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
        {
            // fix weirdness with private PropertyInfos only being returned for the current Type
            // find base type properties and add them to result

            // also find base properties that have been hidden by subtype properties with the same name

            while ((targetType = XTypesBasic.Api.BaseType(targetType)) != null)
            {
                foreach (PropertyInfo propertyInfo in targetType.GetProperties(bindingAttr))
                {
                    PropertyInfo subTypeProperty = propertyInfo;

                    if (!subTypeProperty.IsVirtual())
                    {
                        if (!IsPublic(subTypeProperty))
                        {
                            // have to test on name rather than reference because instances are different
                            // depending on the type that GetProperties was called on
                            int index = initialProperties.IndexOf(p => p.Name == subTypeProperty.Name);
                            if (index == -1)
                            {
                                initialProperties.Add(subTypeProperty);
                            }
                            else
                            {
                                PropertyInfo childProperty = initialProperties[index];
                                // don't replace public child with private base
                                if (!IsPublic(childProperty))
                                {
                                    // replace nonpublic properties for a child, but gotten from
                                    // the parent with the one from the child
                                    // the property gotten from the child will have access to private getter/setter
                                    initialProperties[index] = subTypeProperty;
                                }
                            }
                        }
                        else
                        {
                            int index = initialProperties.IndexOf(p => p.Name == subTypeProperty.Name && p.DeclaringType == subTypeProperty.DeclaringType);

                            if (index == -1)
                            {
                                initialProperties.Add(subTypeProperty);
                            }
                        }
                    }
                    else
                    {
                        Type subTypePropertyDeclaringType = subTypeProperty.GetBaseDefinition()?.DeclaringType ?? subTypeProperty.DeclaringType;

                        int index = initialProperties.IndexOf(p => p.Name == subTypeProperty.Name
                                                                   && p.IsVirtual()
                                                                   && (p.GetBaseDefinition()?.DeclaringType ?? p.DeclaringType).IsAssignableFrom(subTypePropertyDeclaringType));

                        // don't add a virtual property that has an override
                        if (index == -1)
                        {
                            initialProperties.Add(subTypeProperty);
                        }
                    }
                }
            }


        }

        public bool TestAccessibility(PropertyInfo member, BindingFlags bindingFlags)
        {
            if (member.GetMethod != null && XMethodsBase.Api.TestAccessibility(member.GetMethod, bindingFlags))
            {
                return true;
            }

            if (member.SetMethod != null && XMethodsBase.Api.TestAccessibility(member.SetMethod, bindingFlags))
            {
                return true;
            }

            return false;
        }
    }
}
