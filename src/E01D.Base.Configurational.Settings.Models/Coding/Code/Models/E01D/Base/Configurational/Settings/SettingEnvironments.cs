using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings
{
    public class SettingEnvironments
    {
        /// <summary>
        /// Contains a collection of setting environments organized by environment name.
        /// </summary>
        public Dictionary<string, SettingEnvironment> Environments { get; set; } = new Dictionary<string, SettingEnvironment>();

        /// <summary>
        /// Gets or sets the current active enviroment.
        /// </summary>
        public SettingEnvironment Active { get; set; }
    }
}
