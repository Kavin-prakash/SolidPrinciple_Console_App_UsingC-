namespace Atm_Solid_Console_App
{
    public class Atm : IAtm
    {
        private readonly IAccountUser _user;
        private IAuthenticateUserSession _authenticateUserSession;

        // Dependency Injection Principle 
        public Atm(IAccountUser user, IAuthenticateUserSession authenticateUserSession)
        {
            _user = user;
            _authenticateUserSession = authenticateUserSession;
        }

        public void CheckBalance()
        {
            var authenticateduser = _authenticateUserSession.AuthenticatedUser;
            if (authenticateduser != null)
            {
                var userbalace = _user.CheckBalance(authenticateduser.UserCardNumber);
                Console.WriteLine($"You Available Balance is :Rs:{userbalace}");
            }
            else
            {
                Console.WriteLine("User not authenticated. Please login first.");
            }
        }


        public void DepositAmount()
        {
            Console.WriteLine("Please Enter a Money :");
            int userDepositAmount = Convert.ToInt32(Console.ReadLine());

            var authenticatedUser = _authenticateUserSession.AuthenticatedUser;

            if (authenticatedUser != null)
            {
                var userCurrentBalance = _user.DepositAmount(authenticatedUser.UserCardNumber);

                userCurrentBalance = userCurrentBalance + userDepositAmount;

                Console.WriteLine("Money Deposited Successfully:");
                Console.WriteLine($"Now ,Your Availabe Bank Balance is:{userCurrentBalance}");
            }
            else
            {
                Console.WriteLine("Falied to Deposit Amount");
            }
        }

        public void WithdrawAmount()
        {
            System.Console.WriteLine("Enter Amount for Withdraw :");
            int inputUserWithdraw = Convert.ToInt16(Console.ReadLine());

            var authenticatedUser = _authenticateUserSession.AuthenticatedUser;

            var checkUserbalace = _user.DepositAmount(authenticatedUser.UserCardNumber);

            if (checkUserbalace > inputUserWithdraw)
            {

                checkUserbalace = checkUserbalace - inputUserWithdraw;

                Console.WriteLine($"Currently Available Balane is {checkUserbalace}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance:");
            }
        }


    }
}