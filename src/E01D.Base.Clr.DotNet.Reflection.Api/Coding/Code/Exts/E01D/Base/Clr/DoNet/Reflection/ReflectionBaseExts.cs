using System.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection
{
    public static class ReflectionBaseExts
    {

        public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
        {
            return XReflectionBase.Api.RemoveFlag(bindingAttr, flag);
        }

        

        

        


        














        
    }
}
