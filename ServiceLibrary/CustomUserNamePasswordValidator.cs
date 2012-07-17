using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace ServiceLibrary
{
    public class CustomUserNamePasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "intelex"
                || password != "password")
            {
                throw new
                    SecurityTokenValidationException("The user could not be authenticated");
            }
        }
    }
}
