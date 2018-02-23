using System.Collections.Generic;
using Root.Code.Models.E01D.Core.IO;


namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings
{
    public class SettingGlobalContext:SettingGlobalContext_I
    {
        

        public SettingEnvironments Environments { get; set; } = new SettingEnvironments();
        public List<SettingSourceNode_I> SettingSources { get; set; } = new List<SettingSourceNode_I>();
        public DirectoryPath BasePath { get; set; }

        public string KeyDelimiter { get; set; } = ":";
        public SettingModel CurrentModel { get; set; }
    }
}
