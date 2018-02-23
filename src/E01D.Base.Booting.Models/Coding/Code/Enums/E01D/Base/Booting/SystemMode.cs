namespace Root.Coding.Code.Enums.E01D.Base.Booting
{
    public enum SystemMode
    {
        Unknown = 0,
        /// <summary>
        /// Represents the application exists in the cloud.
        /// </summary>
        Cloud = 1,
        /// <summary>
        /// Represents the application is running on a non-cloud based device.
        /// </summary>
        Local = 2
    }
}
