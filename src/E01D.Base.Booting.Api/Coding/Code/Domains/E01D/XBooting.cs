

using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Models.E01D.Base.Booting;

namespace Root.Coding.Code.Domains.E01D
{
    /// <summary>
    /// The purpose of this class is to provide general common functionality from a central point.
    /// </summary>
    public static class XBooting
    {
        /// <summary>
        /// Gets or sets the api associated with booting the system.
        /// </summary>
        public static BootApi Api { get; set; } = new BootApi();

        public static BootApi Boot()
        {
            return Api.Boot();
        }

        public static BootApi Boot(string[] args)
        {
            return Api.Boot(args);
        }


        public static BootApi Boot<TStartup>() where TStartup : Startup_I
        {
            return Api.Boot<TStartup>();
        }

        public static BootApi Boot<TStartup>(string[] args) where TStartup : Startup_I
        {
            return Api.Boot<TStartup>(args);
        }
    }
}
