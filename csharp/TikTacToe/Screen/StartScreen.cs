using TikTacToe.Enum;

using static TikTacToe.UI.Drawer;

namespace TikTacToe.Screen;

public static partial class Screens
{
	public static void StartScreen()
	{
		Divider(DividerCharacter.DoubleLine);
		Text("Welcome to Tik-Tac-Toe!", alignment: HorizontalAlignment.Center);
		Divider(DividerCharacter.DoubleLine);
	}

}
