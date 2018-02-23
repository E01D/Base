namespace Root.Coding.Code.Models.E01D.Base.Booting
{
    /// <summary>
    /// Defines the booting context that can be present on a global ambient context
    /// </summary>
    public interface BootContextHost_I
    {
        /// <summary>
        /// Gets or sets the context containing boot information.
        /// </summary>
        BootContext_I Booting { get; set; }
    }
}
