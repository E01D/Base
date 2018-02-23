using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Models.E01D.Base.Configurational
{
    public interface ConfigurationalGlobalContext_I
    {
        /// <summary>
        /// Gets or sets the name of the active environment.
        /// </summary>
        EnvironmentName_I ActiveEnvironment { get; set; }

        /// <summary>
        /// Gets or sets the context used for managing settings.
        /// </summary>
        SettingGlobalContext_I Settings { get; set; }
    }
}
