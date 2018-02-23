

using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Associations
{
    public interface Association_I : Poco_I
    {
        long From { get; set; }
        long To { get; set; }

        long AssociationType { get; set; }

        
    }
}
