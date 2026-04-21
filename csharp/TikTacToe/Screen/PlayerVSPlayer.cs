using TikTacToe.Enum;

using static TikTacToe.UI.Drawer;

namespace TikTacToe.Screen;

public static partial class Screens
{
    public static void PlayerVSPlayer()
    {
        Console.Clear();

        Divider(DividerCharacter.DoubleLine);
        Text("Player VS Player.", HorizontalAlignment.Center);
        Divider(DividerCharacter.DoubleLine);

        Console.ReadKey();

    }

}
