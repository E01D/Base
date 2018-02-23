using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational.Settings
{
    public class NodeApi
    {
        public SettingNode_I CreateSectionNode(SettingNode_I parent, string pathPiece)
        {
            return new SectionSettingNode()
            {
                Key = pathPiece,
                Parent = parent
            };
        }
    }
}
