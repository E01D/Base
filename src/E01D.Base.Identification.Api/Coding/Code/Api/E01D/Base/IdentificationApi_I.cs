using Root.Coding.Code.Models.E01D.Base.Identification;

namespace Root.Coding.Code.Api.E01D.Base
{
    public interface IdentificationApi_I
    {
        Id_I IssueId();

        T IssueId<T>()
            where T : Identifier_I;

        void IssueId<T>(T identifier)
            where T : Identifier_I;



        IdRange_I IssueRange();

        IdRange_I IssueRange(int size);

        T AssignId<T>(T objectToAssign) where T : Ided_I;

        
    }
}
