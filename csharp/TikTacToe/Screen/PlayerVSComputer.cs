using TikTacToe.Enum;

using static TikTacToe.UI.Drawer;

namespace TikTacToe.Screen;

public static partial class Screens
{
    public static void PlayerVSComputer()
    {
        Player currentPlayer = Player.Player1;

        BoardScreen(GameMode.PlayerVSComputer, currentPlayer);

        Console.ReadKey();
    }
}
