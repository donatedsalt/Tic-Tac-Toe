using TikTacToe.Enum;

namespace TikTacToe.UI;

public partial class Writer
{
    public void Divider(DividerCharacter character = DividerCharacter.SingleLine,
            ConsoleColor? foregroundColor = null,
            ConsoleColor? backgroundColor = null)
    {
        if (foregroundColor != null) Console.ForegroundColor = (ConsoleColor)foregroundColor;
        if (backgroundColor != null) Console.BackgroundColor = (ConsoleColor)backgroundColor;

        Console.WriteLine(new string((char)character, Console.WindowWidth));

        Console.ResetColor();
    }
}
