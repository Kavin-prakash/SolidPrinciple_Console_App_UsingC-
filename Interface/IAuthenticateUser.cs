namespace Atm_Solid_Console_App
{

    public interface IAuthenticateUser
    {
        string AuthenticateUserCrendential(int cardnumber, int cardpin);
    }
}