using TikTacToe.Enum;
using TikTacToe.Screen;

namespace TikTacToe;

internal static class Program
{
    private static void Main()
    {
        GameMode gameMode = GameMode.Invalid;
        while (gameMode == GameMode.Invalid)
        {
            gameMode = Screens.StartScreen();
        }

        if (gameMode == GameMode.PlayerVSPlayer)
        {
            Screens.PlayerVSPlayer();
        }
        else if (gameMode == GameMode.PlayerVSComputer)
        {
            Screens.PlayerVSComputer();
        }
    }
}
