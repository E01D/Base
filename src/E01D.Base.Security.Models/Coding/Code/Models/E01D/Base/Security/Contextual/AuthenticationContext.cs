namespace Root.Coding.Code.Models.E01D.Base.Security.Contextual
{
    public class AuthenticationContext: AuthenticationContext_I
    {
        public UserContext_I User { get; set; }
    }
}
