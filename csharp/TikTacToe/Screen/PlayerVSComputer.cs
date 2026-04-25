using TikTacToe.Enum;

using static TikTacToe.UI.Drawer;

namespace TikTacToe.Screen;

public static partial class Screens
{
    public static bool PlayerVSComputer()
    {
        Grid.Reset();

        Player currentPlayer = Player.Player1;
        Player? winner = null;

        while (winner == null)
        {
            BoardScreen(GameMode.PlayerVSComputer, currentPlayer);

            int position = 0;
            if (currentPlayer == Player.Computer)
            {
                position = GetComputerMove();
            }
            else
            {
                position = int.Parse(Console.ReadKey().KeyChar.ToString());
            }

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

            currentPlayer = currentPlayer == Player.Player1 ? Player.Computer : Player.Player1;
        }

        BoardScreen(GameMode.PlayerVSComputer, winner, true);

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

    private static int GetComputerMove()
    {
        int position = 0;
        while (true)
        {
            position = new Random().Next(1, 10);

            int[]? coords = Grid.GetCellCoords(position);
            if (coords == null) continue;

            Player cell = Grid.GetCellPlayer(coords[0], coords[1]);
            if (cell == Player.Invalid) break;
        }
        return position;
    }
}
