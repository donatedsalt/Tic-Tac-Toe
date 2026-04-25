using TikTacToe.Enum;

using static TikTacToe.UI.Drawer;

namespace TikTacToe.Screen;

public static partial class Screens
{
    public static bool PlayerVSPlayer()
    {
        Grid.Reset();

        Player currentPlayer = Player.Player1;
        Player winner = Player.Invalid;

        while (winner == Player.Invalid)
        {
            BoardScreen(GameMode.PlayerVSPlayer, currentPlayer);

            int position = int.Parse(Console.ReadKey().KeyChar.ToString());

            int[]? coords = Grid.GetCellCoords(position);
            if (coords == null) continue;

            Player cell = Grid.GetCellPlayer(coords[0], coords[1]);

            if (cell == Player.Invalid)
            {
                Grid.Update(coords[0], coords[1], currentPlayer == Player.Player1 ? 'X' : 'O');
            }
            else
            {
                continue;
            }

            winner = Grid.GetWinner();

            currentPlayer = currentPlayer == Player.Player1 ? Player.Player2 : Player.Player1;
        }

        BoardScreen(GameMode.PlayerVSPlayer, winner, true);

        Console.WriteLine("Press 1 to go to the main menu.");
        Console.WriteLine("Press any other key to exit.");

        if (Console.ReadKey().KeyChar == '1')
        {
            Console.Clear();
            return true;
        }
        else
        {
            Console.Clear();
            return false;
        }
    }
}
