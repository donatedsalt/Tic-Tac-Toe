using TikTacToe.Enum;
using TikTacToe.UI;

namespace TikTacToe;

internal static class Program
{
	private static void Main()
	{
		var draw = new Writer();

		draw.Divider(DividerCharacter.DoubleLine);
		draw.Text("Welcome to Tik-Tac-Toe!", alignment: HorizontalAlignment.Center);
		draw.Divider(DividerCharacter.DoubleLine);
	}
}
