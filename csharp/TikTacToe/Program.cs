using TikTacToe.Enum;
using TikTacToe.Screen;

namespace TikTacToe;

internal static class Program
{
    private static void Main()
    {
        // main game loop
        bool continueGame = true;

        while (continueGame)
        {
            // get the game mode from the start screen
            GameMode gameMode = GameMode.Invalid;

            while (gameMode == GameMode.Invalid)
            {
                gameMode = Screens.StartScreen();
            }


            // play the game based on the selected mode
            if (gameMode == GameMode.PlayerVSPlayer)
            {
                continueGame = Screens.PlayerVSPlayer();
            }
            else if (gameMode == GameMode.PlayerVSComputer)
            {
                continueGame = Screens.PlayerVSComputer();
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
