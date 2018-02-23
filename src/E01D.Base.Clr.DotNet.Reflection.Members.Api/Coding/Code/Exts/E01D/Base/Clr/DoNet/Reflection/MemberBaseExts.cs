using System.Reflection;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Clr.DoNet.Reflection
{
    public static class MemberBaseExts
    {


        public static MemberTypes MemberType(this MemberInfo memberInfo)
        {
            return XMembersBase.Api.MemberType(memberInfo);
        }
    }
}
