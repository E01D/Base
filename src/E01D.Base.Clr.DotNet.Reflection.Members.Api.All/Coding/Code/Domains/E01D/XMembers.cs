using System;
using System.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DoNet;
using Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection;


namespace Root.Coding.Code.Domains.E01D
{
    public static class XMembers
    {
        public static MemberApi Api { get; set; } = new MemberApi();


        public static MemberTypes MemberType(MemberInfo memberInfo)
        {
            return Api.MemberType(memberInfo);
        }
    }
}
