using Root.Coding.Code.Models.E01D.Security.Jwt;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XJwt
    {
        public static JwtLoginResult Login(string server, string username, string password)
        {
            return Login(server, "tokens/login", username, password);
        }

        public static JwtLoginResult Login(string server, string path, string username, string password)
        {
            return new JwtLoginResult();
        }
    }
}
