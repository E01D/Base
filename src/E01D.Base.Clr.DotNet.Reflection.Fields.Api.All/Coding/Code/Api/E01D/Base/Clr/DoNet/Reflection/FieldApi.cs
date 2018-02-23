using System.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection
{
    public class FieldApi
    {
        public bool TestAccessibility(FieldInfo member, BindingFlags TestAccessibility)
        {
            return XFieldsBase.Api.TestAccessibility(member, TestAccessibility);
        }


    }
}
