using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Layers.Logical
{
    public class LogicalContext: LogicalContext_I
    {

        /// <summary>
        /// Contains the registered logic apis by type id.
        /// </summary>
        public Dictionary<long, object> LogicApis { get; set; } = new Dictionary<long, object>();


    }
}
