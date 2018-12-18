using System;
namespace GameRPG
{
    public class Fight
    {
       public static void PlayerDead(Player player)
        {
            if (player.Health <= 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tu as échoué !");
                Console.ResetColor();
            }
        }
    }
}
