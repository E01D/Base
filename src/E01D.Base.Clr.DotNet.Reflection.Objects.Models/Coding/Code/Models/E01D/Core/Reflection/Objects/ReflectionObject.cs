using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Clr.DotNet.Reflection;

namespace Root.Coding.Code.Models.E01D.Core.Reflection.Objects
{
    public class ReflectionObject
    {
        public ObjectConstructor<object> Creator { get; set; }
        public IDictionary<string, ReflectionMember> Members { get; set; }

       
    }
}
