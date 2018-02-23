using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Data.Contexts
{
    public class DataGlobalContext: DataGlobalContext_I
    {
        public Dictionary<long, object> DataApis { get; set; } = new Dictionary<long, object>();
        public Dictionary<long, object> DataApisByModelType { get; set; } = new Dictionary<long, object>();
        public object DefaultDataConnectionProvider { get; set; }
        public string DefaultConnectionString { get; set; }
    }
}
