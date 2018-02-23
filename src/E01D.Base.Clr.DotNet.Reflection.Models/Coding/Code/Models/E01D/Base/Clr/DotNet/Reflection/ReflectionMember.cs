using System;

namespace Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection
{
    public  class ReflectionMember
    {
        public System.Type MemberType { get; set; }
        public Func<object, object> Getter { get; set; }
        public Action<object, object> Setter { get; set; }
    }
}
