using System.IO;

namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings.Files
{
    public abstract class FileSettingSourceContext<TSettingSourceNode>:SettingSourceContext_I<TSettingSourceNode>
    {

        public SettingModel Model { get; set; }

        public FileStream Stream { get; set; }
        public TSettingSourceNode SourceNode { get; set; }
    }
}
