using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Models.E01D.Base.Security.Authentication
{
    public class LoginResult:Result<Token>
    {
        public Token Token { get; set; }
    }
}
