namespace Atm_Solid_Console_App
{

    public interface IUser
    {

        int UserCardNumber { get; set; }

        int UserPinNumber { get; set; }

        string? UserName { get; set; }
        long UserContactNumber { get; set; }

        double UserBalance { get; set; }
    }
}