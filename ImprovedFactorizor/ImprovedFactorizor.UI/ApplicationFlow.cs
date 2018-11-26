using System;
using ImprovedFactorizor.BLL;

namespace ImprovedFactorizor.UI
{
    public class ApplicationFlow
    {
        public void Start()
        {
            bool running = true;
            while(running){
                ConsoleOutput.DisplayIntroduction();
                int number = ConsoleInput.GetUserInput();
                ConsoleOutput.DisplayResult(number, Factorize.Factor(number), Factorize.IsPerfect(number),
                                            Factorize.IsPrime(number));
                running = ConsoleInput.GetUserStringInput();
                if(!running)
                {
                    ConsoleOutput.DisplayClosing();
                }
            }
        }
    }
}
