using TikTacToe.Enum;

using static TikTacToe.UI.Drawer;

namespace TikTacToe.Screen;

public static partial class Screens
{
    public static void PlayerVSComputer()
    {
        Console.Clear();

        Divider(DividerCharacter.DoubleLine);
        Text("Player VS Computer.", HorizontalAlignment.Center);
        Divider(DividerCharacter.DoubleLine);

        Console.ReadKey();

    }

}
