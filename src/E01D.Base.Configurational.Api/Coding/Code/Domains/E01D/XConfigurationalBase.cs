using Root.Coding.Code.Api.E01D.Base;

namespace Root.Coding.Code.Domains.E01D
{
    /// <summary>
    /// The purpose of this class is to provide general common functionality from a central point.
    /// </summary>
    public static class XConfigurationalBase
    {
        /// <summary>
        /// Gets the general system api that processes all operations presented by the X class.
        /// </summary>
        public static ConfigurationalApi Api { get; set; } = new ConfigurationalApi();

       
    }
}
