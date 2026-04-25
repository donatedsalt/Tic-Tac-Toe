using TikTacToe.Enum;

namespace TikTacToe.UI;

public static partial class Drawer
{
    internal static void BoardScreen(GameMode GameMode, Player? currentPlayer, bool gameCompleted = false)
    {
        Console.Clear();

        if (GameMode == GameMode.PlayerVSPlayer)
        {
            Divider(DividerCharacter.DoubleLine);
            Text("Player VS Player.", HorizontalAlignment.Center);
            Divider(DividerCharacter.DoubleLine);
        }
        else if (GameMode == GameMode.PlayerVSComputer)
        {
            Divider(DividerCharacter.DoubleLine);
            Text("Player VS Computer.", HorizontalAlignment.Center);
            Divider(DividerCharacter.DoubleLine);
        }

        Grid.Draw();

        if (gameCompleted)
        {
            if (currentPlayer == Player.Invalid)
            {
                Text("It's a draw!", HorizontalAlignment.Center);
            }
            else
            {
                Text($"{currentPlayer?.ToString()} wins!", HorizontalAlignment.Center);
            }
        }
        else
        {
            Text($"{currentPlayer?.ToString()}, Select a position (1-9)", HorizontalAlignment.Center);
        }
    }
}
