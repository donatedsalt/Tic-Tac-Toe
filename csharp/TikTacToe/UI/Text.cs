using TikTacToe.Enum;

namespace TikTacToe.UI;

public static partial class Drawer
{
    public static void Text(string text,
        HorizontalAlignment alignment = HorizontalAlignment.Left,
        ConsoleColor? foregroundColor = null,
        ConsoleColor? backgroundColor = null)
    {
        if (foregroundColor != null) Console.ForegroundColor = (ConsoleColor)foregroundColor;
        if (backgroundColor != null) Console.BackgroundColor = (ConsoleColor)backgroundColor;

        HorizontalAlignCursorPosition(text, alignment);

        Console.WriteLine(text);

        Console.ResetColor();
    }

    private static void HorizontalAlignCursorPosition(string text, HorizontalAlignment alignment)
    {
        switch (alignment)
        {
            case HorizontalAlignment.Left:
                Console.SetCursorPosition(0, Console.CursorTop);
                break;
            case HorizontalAlignment.Center:
                Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
                break;
            case HorizontalAlignment.Right:
                Console.SetCursorPosition(Console.WindowWidth - text.Length, Console.CursorTop);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(alignment), alignment, null);
        }
    }
}
