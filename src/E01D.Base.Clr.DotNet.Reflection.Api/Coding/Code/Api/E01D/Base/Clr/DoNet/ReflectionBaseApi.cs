using System.Reflection;
using Root.Coding.Code.Api.E01D.Base.Clr.DoNet.Reflection;

namespace Root.Coding.Code.Api.E01D.Base.Clr.DoNet
{
    public class ReflectionBaseApi
    {
        public SerializationApi Serialization { get; set; } = new SerializationApi();

        public BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag)
        {
            return ((bindingAttr & flag) == flag)
                ? bindingAttr ^ flag
                : bindingAttr;
        }

        

        

        


        


       






        
    }
}
