

namespace Root.Coding.Code.Models.E01D.Core
{
    public class EnumValue<T> where T : struct
    {
        public string Name
        {
            get; set;
        }

        public T Value
        {
            get; set;
        }
    }
}
