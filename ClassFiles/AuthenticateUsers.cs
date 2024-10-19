namespace Atm_Solid_Console_App
{

    public class AuthenticateUser : IAuthenticateUser
    {

        private readonly IAccountUser _user;

        // private User _AutheticateUser;

        private readonly IAuthenticateUserSession _authenticateUserSession;
        private IAccountUser _accountUser;

        public AuthenticateUser(IAccountUser accountUser, IAuthenticateUserSession authenticateUserSession)
        {
            _accountUser = accountUser;
            _authenticateUserSession = authenticateUserSession;
        }

        public string AuthenticateUserCrendential(int userInputCardNumber, int userInputPinNumber)
        {
            var autheticateUser = _accountUser.GetUserByCardNumberAndPin(userInputCardNumber, userInputPinNumber);

            if (autheticateUser != null)
            {
                _authenticateUserSession.AuthenticatedUser = autheticateUser;

                return $"Card Exists .Welcome,{autheticateUser.UserName}";
            }
            else
            {
                return "Invalid User card Credentials";
            }

        }

    }
}