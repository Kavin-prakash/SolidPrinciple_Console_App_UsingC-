namespace Atm_Solid_Console_App
{

    public class InputHandler : IInputHandler
    {
        public void MenuUserInput()
        {
            int inputMenu = Convert.ToInt32(Console.ReadLine());
        }
    }
}