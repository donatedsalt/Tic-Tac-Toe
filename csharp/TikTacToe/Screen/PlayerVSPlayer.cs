using TikTacToe.Enum;

using static TikTacToe.UI.Drawer;

namespace TikTacToe.Screen;

public static partial class Screens
{
    public static void PlayerVSPlayer()
    {
        Player currentPlayer = Player.Player1;

        Player winner = Player.Invalid;

        while (winner == Player.Invalid)
        {
            BoardScreen(GameMode.PlayerVSPlayer, currentPlayer);

            int position = int.Parse(Console.ReadKey().KeyChar.ToString());

            int[] coords = Grid.GetCellCoords(position);
            Player cell = Grid.GetCellPlayer(coords[0], coords[1]);
            if (cell == Player.Invalid)
            {
                Grid.Update(coords[0], coords[1], currentPlayer == Player.Player1 ? 'X' : 'O');
            }

            winner = Grid.GetWinner();

            currentPlayer = currentPlayer == Player.Player1 ? Player.Player2 : Player.Player1;
        }

        BoardScreen(GameMode.PlayerVSPlayer, winner, true);
        Console.ReadKey();
    }
}
