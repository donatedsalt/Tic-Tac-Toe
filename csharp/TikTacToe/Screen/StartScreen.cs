using TikTacToe.Enum;

using static TikTacToe.UI.Drawer;

namespace TikTacToe.Screen;

public static partial class Screens
{
	public static void StartScreen()
	{
		Console.Clear();

		Divider(DividerCharacter.DoubleLine);
		Text("Welcome to Tik-Tac-Toe!", HorizontalAlignment.Center);
		Divider(DividerCharacter.DoubleLine);

		Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 3);
		Text("Please Select From The Avaliable Game Modes.", HorizontalAlignment.Center);
		Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 5);

		Text("Avaliable Game Modes:");
		Text("1. Player VS Player.");
		Text("2. Player VS Computer.");
		Console.ReadKey();
	}

}
