using Root.Coding.Code.Constants.E01D.Base.Types;
using Root.Coding.Code.Models.E01D.Base.Values;

namespace Root.Coding.Code.Models.E01D.Base.Types
{
    public class StandardTypeId:Valued<long>, TypeId_I, InternalType_I
    {
        /// <summary>
        /// Gets or sets the default type id value for this type in case GetTypeId is called.
        /// </summary>
        long InternalType_I.TypeIdValue => InternalTypeIds.StandardTypeId;

        public TypeId_I TypeId { get; set; }

    }
}
