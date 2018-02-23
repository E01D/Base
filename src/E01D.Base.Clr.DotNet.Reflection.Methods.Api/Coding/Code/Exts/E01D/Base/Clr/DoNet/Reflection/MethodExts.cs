using Root.Coding.Code.Domains.E01D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection
{
    public static class MethodExts
    {
        public static MethodInfo GetBaseDefinition(this MethodInfo method)
        {
            return XMethodsBase.Api.GetBaseDefinition(method);
        }

        public static bool IsMethodOverridden(this Type currentType, Type methodDeclaringType, string method)
        {
            return XMethodsBase.Api.IsMethodOverridden(currentType, methodDeclaringType, method);
        }

        public static MethodInfo Method(this Delegate d)
        {
            return XMethodsBase.Api.Method(d);
        }

        public static bool TestAccessibility(this MethodBase member, BindingFlags bindingFlags)
        {
            return XMethodsBase.Api.TestAccessibility(member, bindingFlags);
        }

        
    }
}
