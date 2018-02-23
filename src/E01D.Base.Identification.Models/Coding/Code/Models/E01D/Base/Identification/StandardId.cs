using Root.Coding.Code.Constants.E01D.Base.Types;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Models.E01D.Base.Identification
{
    public class StandardId:Identifier, Id_I
    {
        public TypeId_I TypeId { get; set; }

        /// <summary>
        /// Gets or sets the default type id value for this type in case GetTypeId is called.
        /// </summary>
        long InternalType_I.TypeIdValue => InternalTypeIds.StandardId;

        
    }
}
