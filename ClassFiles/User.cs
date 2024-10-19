namespace Atm_Solid_Console_App
{
    public class User : IUser
    {
        public int UserCardNumber { get; set; }

        public int UserPinNumber { get; set; }

        public string? UserName { get; set; }
        public long UserContactNumber { get; set; }

        public double UserBalance { get; set; }


        public User(int usercardnumber, int userpinnumber, string username, long usercontactnumer, double userbalance)
        {
            UserCardNumber = usercardnumber;
            UserPinNumber = userpinnumber;
            UserName = username;
            UserContactNumber = usercontactnumer;
            UserBalance = userbalance;
        }
    }
}