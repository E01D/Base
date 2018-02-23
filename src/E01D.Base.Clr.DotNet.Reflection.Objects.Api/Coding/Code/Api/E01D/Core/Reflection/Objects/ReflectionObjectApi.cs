using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Root.Coding.Code.Domains.E01D;
//using Root.Coding.Code.Exts.E01D.Core.Reflection.Emit;
using Root.Coding.Code.Exts.E01D.Strings;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection;
using Root.Coding.Code.Models.E01D.Core.Reflection.Emit.DelegateFactories;
using Root.Coding.Code.Models.E01D.Core.Reflection.Objects;


namespace Root.Coding.Code.Api.E01D.Core.Reflection.Objects
{
    public class ReflectionObjectApi
    {
        public ReflectionObject Create(ObjectConstructor<object> creator)
        {

            return new ReflectionObject()
            {
                Members = new Dictionary<string, ReflectionMember>(),
                Creator = creator
            };    
        }

        public object GetValue(ReflectionObject reflectionObject, object target, string member)
        {
            Func<object, object> getter = reflectionObject.Members[member].Getter;
            return getter(target);
        }

        

        public Type GetType(ReflectionObject reflectionObject, string member)
        {
            return reflectionObject.Members[member].MemberType;
        }

        

        public void SetValue(ReflectionObject reflectionObject, object target, string member, object value)
        {
            Action<object, object> setter = reflectionObject.Members[member].Setter;
            setter(target, value);
        }

     

        

        public ReflectionObject Create(Type t, params string[] memberNames)
        {
            return Create(t, null, memberNames);
        }

        public ReflectionObject Create(Type t, MethodBase creator, params string[] memberNames)
        {
            //ReflectionDelegateFactory delegateFactory = XEmit.GetReflectionDelegateFactory();

            //ObjectConstructor<object> creatorConstructor = null;
            //if (creator != null)
            //{
            //    creatorConstructor = delegateFactory.CreateParameterizedConstructor(creator);
            //}
            //else
            //{
            //    if (XReflection.Api.HasDefaultConstructor(t, false))
            //    {
            //        Func<object> ctor = delegateFactory.CreateDefaultConstructor<object>(t);

            //        creatorConstructor = args => ctor();
            //    }
            //}

            //ReflectionObject d = Create(creatorConstructor);

            //foreach (string memberName in memberNames)
            //{
            //    MemberInfo[] members = t.GetMember(memberName, BindingFlags.Instance | BindingFlags.Public);
            //    if (members.Length != 1)
            //    {
            //        throw new ArgumentException("Expected a single member with the name '{0}'.".FormatWith(CultureInfo.InvariantCulture, memberName));
            //    }

            //    MemberInfo member = members.Single();

            //    ReflectionMember reflectionMember = new ReflectionMember();

            //    switch (member.MemberType)
            //    {
            //        case MemberTypes.Field:
            //        case MemberTypes.Property:
            //            if (XReflection.Api.CanReadMemberValue(member, false))
            //            {
            //                reflectionMember.Getter = delegateFactory.CreateGet<object>(member);
            //            }

            //            if (XReflection.Api.CanSetMemberValue(member, false, false))
            //            {
            //                reflectionMember.Setter = delegateFactory.CreateSet<object>(member);
            //            }
            //            break;
            //        case MemberTypes.Method:
            //            MethodInfo method = (MethodInfo)member;
            //            if (method.IsPublic)
            //            {
            //                ParameterInfo[] parameters = method.GetParameters();
            //                if (parameters.Length == 0 && method.ReturnType != typeof(void))
            //                {
            //                    MethodCall<object, object> call = delegateFactory.CreateMethodCall<object>(method);
            //                    reflectionMember.Getter = target => call(target);
            //                }
            //                else if (parameters.Length == 1 && method.ReturnType == typeof(void))
            //                {
            //                    MethodCall<object, object> call = delegateFactory.CreateMethodCall<object>(method);
            //                    reflectionMember.Setter = (target, arg) => call(target, arg);
            //                }
            //            }
            //            break;
            //        default:
            //            throw new ArgumentException("Unexpected member type '{0}' for member '{1}'.".FormatWith(CultureInfo.InvariantCulture, member.MemberType, member.Name));
            //    }

            //    if (XReflection.Api.CanReadMemberValue(member, false))
            //    {
            //        reflectionMember.Getter = delegateFactory.CreateGet<object>(member);
            //    }

            //    if (XReflection.Api.CanSetMemberValue(member, false, false))
            //    {
            //        reflectionMember.Setter = delegateFactory.CreateSet<object>(member);
            //    }

            //    reflectionMember.MemberType = XReflection.Api.GetMemberUnderlyingType(member);

            //    d.Members[memberName] = reflectionMember;
            //}

            //return d;
            throw new System.NotImplementedException();
        }

        public ReflectionObject ReflectionObject(Type t, params string[] memberNames)
        {
            return ReflectionObject(t, null, memberNames);
        }

        public ReflectionObject ReflectionObject(ObjectConstructor<object> creator)
        {
            return new ReflectionObject()
            {
                Members = new Dictionary<string, ReflectionMember>(),
                Creator = creator,
            };
        }

        public ReflectionObject ReflectionObject(Type t, MethodBase creator, params string[] memberNames)
        {
            throw XExceptions.NotImplemented.ToBeImplementedAtALaterDate();
            //ReflectionDelegateFactory delegateFactory = XReflection.Api.ReflectionDelegateFactory;

            //ObjectConstructor<object> creatorConstructor = null;
            //if (creator != null)
            //{
            //    creatorConstructor = delegateFactory.CreateParameterizedConstructor(creator);
            //}
            //else
            //{
            //    if (XReflection.HasDefaultConstructor(t, false))
            //    {
            //        Func<object> ctor = delegateFactory.CreateDefaultConstructor<object>(t);

            //        creatorConstructor = args => ctor();
            //    }
            //}

            //ReflectionObject d = new ReflectionObject(creatorConstructor);

            //foreach (string memberName in memberNames)
            //{
            //    MemberInfo[] members = t.GetMember(memberName, BindingFlags.Instance | BindingFlags.Public);
            //    if (members.Length != 1)
            //    {
            //        throw new ArgumentException("Expected a single member with the name '{0}'.".FormatWith(CultureInfo.InvariantCulture, memberName));
            //    }

            //    MemberInfo member = members.Single();

            //    ReflectionMember reflectionMember = new ReflectionMember();

            //    switch (member.MemberType())
            //    {
            //        case MemberTypes.Field:
            //        case MemberTypes.Property:
            //            if (XReflection.Api.CanReadMemberValue(member, false))
            //            {
            //                reflectionMember.Getter = delegateFactory.CreateGet<object>(member);
            //            }

            //            if (XReflection.Api.CanSetMemberValue(member, false, false))
            //            {
            //                reflectionMember.Setter = delegateFactory.CreateSet<object>(member);
            //            }
            //            break;
            //        case MemberTypes.Method:
            //            MethodInfo method = (MethodInfo)member;
            //            if (method.IsPublic)
            //            {
            //                ParameterInfo[] parameters = method.GetParameters();
            //                if (parameters.Length == 0 && method.ReturnType != typeof(void))
            //                {
            //                    MethodCall<object, object> call = delegateFactory.CreateMethodCall<object>(method);
            //                    reflectionMember.Getter = target => call(target);
            //                }
            //                else if (parameters.Length == 1 && method.ReturnType == typeof(void))
            //                {
            //                    MethodCall<object, object> call = delegateFactory.CreateMethodCall<object>(method);
            //                    reflectionMember.Setter = (target, arg) => call(target, arg);
            //                }
            //            }
            //            break;
            //        default:
            //            throw new ArgumentException("Unexpected member type '{0}' for member '{1}'.".FormatWith(CultureInfo.InvariantCulture, member.MemberType(), member.Name));
            //    }

            //    if (XReflection.Api.CanReadMemberValue(member, false))
            //    {
            //        reflectionMember.Getter = delegateFactory.CreateGet<object>(member);
            //    }

            //    if (XReflection.Api.CanSetMemberValue(member, false, false))
            //    {
            //        reflectionMember.Setter = delegateFactory.CreateSet<object>(member);
            //    }

            //    reflectionMember.MemberType = XReflection.Api.GetMemberUnderlyingType(member);

            //    d.Members[memberName] = reflectionMember;
            //}

            //return d;
        }

        
    }
}
