using System;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection
{
    public class MemberApi
    {


//        public T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
//        {
//            T attribute;

//#if !(NET20 || DOTNET)
//            Type metadataType = XBaseTypes.GetAssociatedMetadataType(memberInfo.DeclaringType);
//            if (metadataType != null)
//            {
//                MemberInfo metadataTypeMemberInfo = XBaseTypes.Api.GetMemberInfoFromType(metadataType, memberInfo);

//                if (metadataTypeMemberInfo != null)
//                {
//                    attribute = XAttributes.Api.GetAttribute<T>(metadataTypeMemberInfo, true);
//                    if (attribute != null)
//                    {
//                        return attribute;
//                    }
//                }
//            }
//#endif

//            attribute = XAttributes.Api.GetAttribute<T>(memberInfo, true);
//            if (attribute != null)
//            {
//                return attribute;
//            }

//            if (memberInfo.DeclaringType != null)
//            {
//                foreach (Type typeInterface in memberInfo.DeclaringType.GetInterfaces())
//                {
//                    MemberInfo interfaceTypeMemberInfo = XBaseTypes.Api.GetMemberInfoFromType(typeInterface, memberInfo);

//                    if (interfaceTypeMemberInfo != null)
//                    {
//                        attribute = XAttributes.Api.GetAttribute<T>(interfaceTypeMemberInfo, true);
//                        if (attribute != null)
//                        {
//                            return attribute;
//                        }
//                    }
//                }
//            }

//            return null;
//        }


        public bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
        {
            if (memberInfo.MemberType() != MemberTypes.Property)
            {
                return false;
            }

            PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
            if (!XProperties.Api.IsVirtual(propertyInfo))
            {
                return false;
            }

            Type declaringType = propertyInfo.DeclaringType;
            if (!XTypesBasic.Api.IsGenericType(declaringType))
            {
                return false;
            }
            Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
            if (genericTypeDefinition == null)
            {
                return false;
            }
            MemberInfo[] members = genericTypeDefinition.GetMember(propertyInfo.Name, bindingAttr);
            if (members.Length == 0)
            {
                return false;
            }
            Type memberUnderlyingType = XMembersBase.Api.GetMemberUnderlyingType(members[0]);
            if (!memberUnderlyingType.IsGenericParameter)
            {
                return false;
            }

            return true;
        }

        public bool TestAccessibility(MemberInfo member, BindingFlags bindingFlags)
        {
            if (member is FieldInfo)
            {
                return XFieldsBase.Api.TestAccessibility((FieldInfo)member, bindingFlags);
            }
            else if (member is MethodBase)
            {
                return XMethods.Api.TestAccessibility((MethodBase)member, bindingFlags);
            }
            else if (member is PropertyInfo)
            {
                return XProperties.Api.TestAccessibility((PropertyInfo)member, bindingFlags);
            }

            throw new Exception("Unexpected member type.");
        }

        public MemberTypes MemberType(MemberInfo memberInfo)
        {
            return XMembersBase.Api.MemberType(memberInfo);
        }

        public Type GetMemberUnderlyingType(MemberInfo member)
        {
            return XMembersBase.Api.GetMemberUnderlyingType(member);
        }

        public bool IsIndexedProperty(MemberInfo member)
        {
            return XMembersBase.Api.IsIndexedProperty(member);
        }

        public object GetMemberValue(MemberInfo member, object target)
        {
            return XMembersBase.Api.GetMemberValue(member, target);
        }

        public void SetMemberValue(MemberInfo member, object target, object value)
        {
            XMembersBase.Api.SetMemberValue(member, target, value);
        }

        public bool CanReadMemberValue(MemberInfo member, bool nonPublic)
        {
            return XMembersBase.Api.CanReadMemberValue(member, nonPublic);
        }

        public bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
        {
            return XMembersBase.Api.CanSetMemberValue(member, nonPublic, canSetReadOnly);
        }
    }
}
