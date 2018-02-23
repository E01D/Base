using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Layers.Logical
{
    public interface LogicalContext_I
    {
        /// <summary>
        /// Contains the registered logic apis by type id.
        /// </summary>
        Dictionary<long, object> LogicApis { get; set; } 
    }
}
