using System.Collections.Generic;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings
{
    public interface SettingGlobalContext_I
    {
        

        /// <summary>
        /// Gets or sets the setting environments.
        /// </summary>
        SettingEnvironments Environments { get; set; }

        List<SettingSourceNode_I> SettingSources { get; set; }
        DirectoryPath BasePath { get; set; }

        string KeyDelimiter { get; set; }
        SettingModel CurrentModel { get; set; }
    }
}
