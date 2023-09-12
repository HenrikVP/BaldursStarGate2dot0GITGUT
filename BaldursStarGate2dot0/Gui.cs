namespace BaldursStarGate2dot0
{
    internal class Gui
    {
        //TODO Possible refactoring, combining the two methods to one.
        public static void ShowPlayer(Player player)
        {
            if (player == null) return;
            Print(3, 1, $"{player} Gold: {player.Gold}");
            Print(3, 2, $"Health : {player.Health} / {player.MaxHealth}".PadRight(5), ConsoleColor.Red);
        }

        public static void ShowMonster(Monster monster)
        {
            if (monster == null) return;
            Print(30, 1, $"{monster} Gold: {monster.Gold}");
            Print(30, 2, $"Health : {monster.Health} / {monster.MaxHealth}".PadRight(5), ConsoleColor.Red);
        }

        public static void Print(int x, int y, string text, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
