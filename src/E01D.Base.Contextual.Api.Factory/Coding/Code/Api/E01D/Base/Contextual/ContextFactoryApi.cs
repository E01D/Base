using Root.Coding.Code.Models.E01D.Base.Contextual;

namespace Root.Coding.Code.Api.E01D.Base.Contextual
{
    public class ContextFactoryApi:ContextFactory_I
    {
        public object Create()
        {
            return new DefaultContext();
        }
    }
}
