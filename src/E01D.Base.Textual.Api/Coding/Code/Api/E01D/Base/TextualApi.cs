using System.Text;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class TextualApi
    {
        public string StripNulls(string configText)
        {
            var builder = new StringBuilder();

            foreach (var characater in configText)
            {
                if (characater == '\0') continue;

                builder.Append(characater);
            }

            return builder.ToString();
        }
    }
}
