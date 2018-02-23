namespace Root.Coding.Code.Models.E01D.Base.Security.Authentication
{
    public class UserCredentials
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public string UserAgreement { get; set; }

        public string PrivacyPolicy { get; set; }

        public string AcceptanceToken { get; set; }
    }
}
