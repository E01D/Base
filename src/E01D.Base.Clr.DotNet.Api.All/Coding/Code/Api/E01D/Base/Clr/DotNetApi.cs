using Root.Coding.Code.Api.E01D.Base.Clr.DoNet;
//using Root.Coding.Code.Api.E01D.Core.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Clr
{
    public class DotNetApi
    {
        //public EmitApi Emit => XEmit.Api;

        public ReflectionApi Reflection => XReflection.Api;
    }
}
