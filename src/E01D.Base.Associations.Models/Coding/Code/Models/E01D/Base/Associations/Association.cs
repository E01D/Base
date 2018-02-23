using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Associations
{
    public class Association : Poco
    {
        public long From { get; set; }
        public long To { get; set; }

        public int AssociationType { get; set; }
    }
}
