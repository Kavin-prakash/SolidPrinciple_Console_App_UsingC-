namespace Atm_Solid_Console_App
{

    public interface IAuthenticateUserSession
    {
        User AuthenticatedUser { get; set; }
    }
}