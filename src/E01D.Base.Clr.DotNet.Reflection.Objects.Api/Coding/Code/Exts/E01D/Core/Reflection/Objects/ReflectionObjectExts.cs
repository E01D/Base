using System;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Core.Reflection.Objects;

namespace Root.Coding.Code.Exts.E01D.Core.Reflection.Objects
{
    public static class ReflectionObjectExts
    {
        public static object GetValue(this ReflectionObject reflectionObject, object target, string member)
        {
            return XReflectionObjects.Api.GetValue(reflectionObject, target, member);
        }

        public static void SetValue(this ReflectionObject reflectionObject, object target, string member, object value)
        {
            XReflectionObjects.Api.SetValue(reflectionObject, target, member, value);
        }

        public static Type GetType(this ReflectionObject reflectionObject, string member)
        {
            return XReflectionObjects.Api.GetType(reflectionObject, member);
        }

        //public static ReflectionObject Create(Type t, params string[] memberNames)
        //{
        //    return XReflectionObjects.Api.Create(t, memberNames);
        //}

        //public static ReflectionObject Create(Type t, MethodBase creator, params string[] memberNames)
        //{
        //    return XReflectionObjects.Api.Create(t, creator, memberNames);
        //}
    }
}
