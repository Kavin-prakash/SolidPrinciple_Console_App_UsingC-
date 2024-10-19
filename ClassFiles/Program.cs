using System;
namespace Atm_Solid_Console_App
{
    public class Program
    {
        private readonly IAtm _atm;

        private IInputHandler _inputHandler;

        private IAuthenticateUser _authenticateUser;

        private IAuthenticateUserSession _authenticateUserSession;
        public Program(IAtm atm, IInputHandler inputHandler, IAuthenticateUser authenticateUser, IAuthenticateUserSession authenticateUserSession)    // Dependency Injection 
        {
            _atm = atm;
            _inputHandler = inputHandler;
            _authenticateUser = authenticateUser;
            _authenticateUserSession = authenticateUserSession;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome ATM Management System----");

            IAccountUser accountUser = new AccountUsers();

            IAuthenticateUserSession authenticateUserSession = new AuthenticateUserSession();

            IAtm atm = new Atm(accountUser, authenticateUserSession);

            IAuthenticateUser authenticateUser = new AuthenticateUser(accountUser, authenticateUserSession);


            Console.WriteLine("Enter your ATM Card Number:");
            int cardNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Pin Number:");
            int pinNumber = Convert.ToInt32(Console.ReadLine());


            var result = authenticateUser.AuthenticateUserCrendential(cardNumber, pinNumber);

            Console.WriteLine(result);

            if (result.Contains("Welcome"))
            {
                ShowAccountMenuToUser(atm);
            }
            else
            {
                Console.WriteLine("Authentication Failed . Please Try again");
            }
        }


        public static void ShowAccountMenuToUser(IAtm atm)
        {
            Console.WriteLine("Once Again Welcome to ATM Application :");
            Console.WriteLine("--------------------------------------");

            while (true)
            {
                Console.WriteLine("1. Check Account Balance :");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        atm.CheckBalance();
                        break;

                    case 2:
                        atm.DepositAmount();
                        break;

                    case 3:
                        atm.WithdrawAmount();
                        break;

                    case 4:
                        Console.WriteLine("Exiting. Thank you for using the ATM.");
                        return; // Exits the Method

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

    }
}