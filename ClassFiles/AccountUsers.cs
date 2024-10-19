namespace Atm_Solid_Console_App
{

    public class AccountUsers : IAccountUser
    {
        private readonly List<User> _user;

        public AccountUsers()
        {
            _user = new List<User>{
                new User(10001, 1523, "Kavin Prakash", 9786248795,25300.00),
                new User(10002, 7859, "James Bond", 75248596,25355.00),
                new User(10003, 7412, "Daniel Balaji", 8521479632,85964.00),
                new User(10004, 9632, "Surya Kumar", 8521479635,85633.00),
                new User(10004, 7859, "Dhoni", 7418529638,5864.00),
                new User(10004, 2516, "Virat Kholi", 7548296325,85964.00),
            };
        }
        public User GetUserByCardNumberAndPin(int cardnumber, int cardpin)
        {
            return _user.FirstOrDefault(user => user.UserCardNumber == cardnumber && user.UserPinNumber == cardpin);
        }


        public double CheckBalance(int cardNumber)
        {
            var user = _user.FirstOrDefault(u => u.UserCardNumber == cardNumber);
            return user?.UserBalance ?? 0.0;
        }

        public double DepositAmount(int cardNumber)
        {
            var usercurrentbalance = _user.FirstOrDefault(user => user.UserCardNumber == cardNumber);
            return usercurrentbalance?.UserBalance ?? 0.0;
        }

    }
}