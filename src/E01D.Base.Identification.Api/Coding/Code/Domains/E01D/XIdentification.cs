using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Models.E01D.Base.Identification;


namespace Root.Coding.Code.Domains.E01D
{
    public static class XIdentification
    {
        public static IdentificationApi Api { get; set; } = new IdentificationApi();

        public static void Initialize()
        {
            

            Api.Initialize();
        }

        public static Id_I IssueId()
        {
            return Api.IssueId();
        }

        public static T IssueId<T>()
            where T: Identifier_I
        {
            return Api.IssueId<T>();
        }

        public static void IssueId<T>(T newIdentifier)
            where T : Identifier_I
        {
            Api.IssueId<T>(newIdentifier);
        }

        public static IdRange_I IssueRange(int size)
        {
            return Api.IssueRange(size);
        }

        public static T AssignId<T>(T objectToAssign)
            where T : Ided_I
        {
            return Api.AssignId<T>(objectToAssign);
        }

        public static Ided_I AssignId( Ided_I objectToAssign)
        {
            return Api.AssignId(objectToAssign);
        }

        
    }
}
