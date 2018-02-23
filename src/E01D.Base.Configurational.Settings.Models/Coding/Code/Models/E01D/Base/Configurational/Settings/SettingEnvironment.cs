namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings
{
    public class SettingEnvironment
    {
        /// <summary>
        /// Gets or sets the name of the environment
        /// </summary>
        public string Name { get; set; } = "Production";

        /// <summary>
        /// Gets or sets the default model that is constructed from various setting sources.
        /// </summary>
        public SettingModel DefaultModel { get; set; }
    }
}
