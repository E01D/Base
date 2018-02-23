using System;
using System.Linq;
using System.Reflection;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection
{
    public class MethodBaseApi
    {
        public MethodInfo GetBaseDefinition(MethodInfo method)
        {
            return method.GetRuntimeBaseDefinition();
        }

        public bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
        {
            bool isMethodOverriden = currentType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .Any(info =>
                    info.Name == method &&
                    // check that the method overrides the original on DynamicObjectProxy
                    info.DeclaringType != methodDeclaringType
                    && info.GetBaseDefinition().DeclaringType == methodDeclaringType
                );

            return isMethodOverriden;
        }

        public MethodInfo Method(Delegate d)
        {
            return d.Method;
        }

        

        public bool TestAccessibility(MethodBase member, BindingFlags bindingFlags)
        {
            bool visibility = (member.IsPublic && bindingFlags.HasFlag(BindingFlags.Public)) ||
                              (!member.IsPublic && bindingFlags.HasFlag(BindingFlags.NonPublic));

            bool instance = (member.IsStatic && bindingFlags.HasFlag(BindingFlags.Static)) ||
                            (!member.IsStatic && bindingFlags.HasFlag(BindingFlags.Instance));

            return visibility && instance;
        }
    }
}
