using Root.Coding.Code.Api.E01D.Base.Clr;
using Root.Coding.Code.Api.E01D.Base.Clr.DoNet;
//using Root.Coding.Code.Api.E01D.Core.Reflection;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XDotNet
    {
        public static DotNetApi Api { get; set; } = new DotNetApi();

        //public static EmitApi Emit => Api.Emit;

        public static ReflectionApi Reflection => Api.Reflection;
    }
}
