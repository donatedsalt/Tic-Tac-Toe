using TikTacToe.Screen;

namespace TikTacToe;

internal static class Program
{
    private static void Main()
    {
        int GameMode = 0;
        while (GameMode == 0)
        {
            GameMode = Screens.StartScreen();
        }

        if (GameMode == 1)
        {
            Screens.PlayerVSPlayer();
        }
        else if (GameMode == 2)
        {
            Screens.PlayerVSComputer();
        }
    }
}
