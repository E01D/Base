using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Data.Contexts
{
    public interface DataGlobalContext_I
    {
        Dictionary<long, object> DataApis { get; set; }
        Dictionary<long, object> DataApisByModelType { get; set; }

        object DefaultDataConnectionProvider { get; set; }
        string DefaultConnectionString { get; set; }
    }
}
