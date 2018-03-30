using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace WCFExample.Authentication
{
    public class AuthenticationValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (!(userName == "bardzo" && password == "tajne"))
            {
                throw new FaultException("Unknown Username or Incorrect Password");
            }
        }
    }
}