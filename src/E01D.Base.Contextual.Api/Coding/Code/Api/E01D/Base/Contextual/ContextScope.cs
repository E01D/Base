using System;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base.Contextual
{
    public class ContextScope:IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            XContextualBase.Dispose();
        }

        ~ContextScope()
        {
            Dispose(false);
        }
    }
}
