namespace Root.Coding.Code.Models.E01D.Base.Configurational.Settings
{
    public interface SettingSourceContext_I<TSettingSourceNode>
    {
        SettingModel Model { get; set; }

        TSettingSourceNode SourceNode { get; set; }
    }
}
