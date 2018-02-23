using Root.Coding.Code.Enums.E01D.Base.Booting;

namespace Root.Coding.Code.Models.E01D.Base.Booting
{
    /// <summary>
    /// Gets or sets the ambient context that stores boot information.
    /// </summary>
    public interface BootContext_I
    {
        /// <summary>
        /// Gets or sets whether the system has been booted.
        /// </summary>
        bool Booted { get; set; }

        /// <summary>
        /// Gets or sets the startup options
        /// </summary>
        Startup_I Startup { get; set; }

        /// <summary>
        /// Gets or sets the system mode 
        /// </summary>
        SystemMode SystemMode { get; set; }

        
    }
}
