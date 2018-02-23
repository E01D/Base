using System.Collections.Generic;
using System.Threading;
using Root.Coding.Code.Api.E01D.Base.Containers.Ioc;

namespace Root.Coding.Code.Models.E01D.Base.Contextual
{
    public static class ContextualGlobals
    {
        public static object GlobalContext { get; set; } = new DefaultGlobalContext();

        public static BasicIocContainer_I GlobalContexts { get; set; } = new BasicIocContainer();

        public static AsyncLocal<LocalContext> Contexts { get; set; } = new AsyncLocal<LocalContext>();

    }
}
