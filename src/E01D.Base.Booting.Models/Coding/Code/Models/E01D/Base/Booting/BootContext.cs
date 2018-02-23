using Root.Coding.Code.Enums.E01D.Base.Booting;

namespace Root.Coding.Code.Models.E01D.Base.Booting
{
    /// <summary>
    /// Gets or sets the ambient context that stores boot information.
    /// </summary>
    public class BootContext:BootContext_I
    {
        /// <summary>
        /// Gets or sets whether the system has booted.
        /// </summary>
        public bool Booted { get; set; }

        /// <summary>
        /// Gets or sets the startup options
        /// </summary>
        public Startup_I Startup { get; set; }

        /// <summary>
        /// Gets or sets the system mode 
        /// </summary>
        public SystemMode SystemMode { get; set; }

        
    }
}
