namespace Atm_Solid_Console_App
{
    public interface IAccountUser
    {
        User GetUserByCardNumberAndPin(int cardnumber, int cardpin);

        double CheckBalance(int cardnumber);

        double DepositAmount(int depositAmount);
        
    }
}