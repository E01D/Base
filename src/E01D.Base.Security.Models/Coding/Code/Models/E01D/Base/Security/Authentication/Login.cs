﻿using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Models.E01D.Base.Security.Authentication
{
    public class Login:Poco
    {
        public string EmailAddress { get; set; }

        public string Password { get; set; }
    }
}
