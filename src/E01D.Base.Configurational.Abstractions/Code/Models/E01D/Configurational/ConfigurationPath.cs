namespace Root.Code.Models.E01D.Configurational
{
    public class ConfigurationPath
    {
        public ConfigurationPath()
        {

        }

        public ConfigurationPath(string @value)
        {
            Value = @value;
        }

        public string Value { get; set; }
    }
}
