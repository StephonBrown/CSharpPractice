using System;
using GuessingGame.BLL;

namespace SB.GuessingGame.UI
{
    public class GameFlow
    {
        GameManager _gm;

        public void PlayGame()
        {
            CreateGameManagerInstance();
            ConsoleOutput.DisplayTitle();

            GuessResult result;
            int guess;

            do
            {
                guess = ConsoleInput.GetGuessFromUser();
                result = _gm.ProcessGuess(guess);
                ConsoleOutput.DisplayGuessMessage(result);

            } while (result != GuessResult.Victory);

        }

        private void CreateGameManagerInstance()
        {
            _gm = new GameManager();
            _gm.Start();
        }
    }
}
