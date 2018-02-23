using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection
{
    public class MethodApi
    {
        public MethodInfo GetBaseDefinition(MethodInfo method)
        {
            return XMethodsBase.Api.GetBaseDefinition(method);
        }

        public bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
        {
            return XMethodsBase.Api.IsMethodOverridden(currentType, currentType, method);
        }

        public MethodInfo Method(Delegate d)
        {
            return XMethodsBase.Api.Method(d);
        }

        public bool TestAccessibility(MethodBase member, BindingFlags bindingFlags)
        {
            return XMethodsBase.Api.TestAccessibility(member, bindingFlags);
        }
    }
}
