using Root.Coding.Code.Models.E01D.Web.Apis;

namespace Root.Coding.Code.Models.E01D.Core.Data.Framework
{
    [DbCategory("Global")]
    public class Reference
    {
        /// <summary>
        /// Gets or sets the id associated with the instance
        /// </summary>
        [PrimaryKey]
        public long Id { get; set; }

        public long FromId { get; set; }

        public long ToId { get; set; }
        public int ReferenceType { get; set; }
    }
}
