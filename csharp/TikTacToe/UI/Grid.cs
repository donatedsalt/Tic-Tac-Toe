using TikTacToe.Enum;

namespace TikTacToe.UI;

public static partial class Drawer
{
    public static class Grid
    {
        private static char[,] board = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

        public static char[,] Board => board;

        public static Player GetCellPlayer(int row, int col)
        {
            return board[row, col] == 'X' ? Player.Player1 : board[row, col] == 'O' ? Player.Player2 : Player.Invalid;
        }

        public static int[]? GetCellCoords(int position)
        {
            if (position < 1 || position > 9) return null;

            int row = (position - 1) / 3;
            int col = (position - 1) % 3;
            return [row, col];
        }

        public static void Update(int row, int col, char value)
        {
            board[row, col] = value;
        }

        public static Player? GetWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return board[i, 0] == 'X' ? Player.Player1 : Player.Player2;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return board[0, i] == 'X' ? Player.Player1 : Player.Player2;
                }
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0] == 'X' ? Player.Player1 : Player.Player2;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return board[0, 2] == 'X' ? Player.Player1 : Player.Player2;
            }

            if (IsFull())
            {
                return Player.Invalid;
            }

            return null;
        }

        public static bool IsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '1' || board[i, j] == '2' || board[i, j] == '3' ||
                        board[i, j] == '4' || board[i, j] == '5' || board[i, j] == '6' ||
                        board[i, j] == '7' || board[i, j] == '8' || board[i, j] == '9')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void Reset()
        {
            board = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        }

        public static void Draw()
        {
            string Section = "         │         │         \n    a    │    b    │    c    \n         │         │         ";
            string Seperator = "─────────┼─────────┼─────────";

            string Board = $"""
            {Section.Replace('a', board[0, 0]).Replace('b', board[0, 1]).Replace('c', board[0, 2])}
            {Seperator}
            {Section.Replace('a', board[1, 0]).Replace('b', board[1, 1]).Replace('c', board[1, 2])}
            {Seperator}
            {Section.Replace('a', board[2, 0]).Replace('b', board[2, 1]).Replace('c', board[2, 2])}
            """;

            Console.SetCursorPosition(0, Console.GetCursorPosition().Top + 2);
            Text(Board, HorizontalAlignment.Center);
            Console.SetCursorPosition(0, Console.GetCursorPosition().Top + 2);
        }
    }
}
