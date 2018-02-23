using Root.Coding.Code.Api.E01D.Base.Containers.Ioc;

namespace Root.Coding.Code.Models.E01D.Base.Contextual
{
    public class LocalContext
    {
        public object Context { get; set; }

        public BasicIocContainer_I Contexts = new BasicIocContainer();
    }
}
