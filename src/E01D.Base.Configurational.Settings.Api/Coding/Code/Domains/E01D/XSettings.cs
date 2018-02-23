using Root.Coding.Code.Api.E01D.Base.Configurational;
using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XSettings
    {
        public static SettingApi Api { get; set; } = new SettingApi();

        public static string GetString(string keyPath)
        {
            return Api.GetString(keyPath);
        }

        public static int GetInt32(string keyPath)
        {
            return Api.GetInt32(keyPath);
        }

        public static bool GetString(string keyPath, out string result)
        {
            return Api.GetString(keyPath, out result);
        }

        public static SettingNode_I Set(string keypath, string valueToSet)
        {
            return Api.Set(keypath, valueToSet);
        }

        public static SettingNode_I SetAndPersist(string keypath, string valueToSet)
        {
            return Api.SetAndPersist(keypath, valueToSet);
        }

        public static SettingNode_I GetNode(string keyPath)
        {
            return Api.GetNode(keyPath);
        }

        
    }
}
