using System;
using GameRPG.Personnages;

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

        public static void EnemyDead(Enemy enemy, string NameHero)
        {
            if (enemy.Health <= 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("l'ennemi est mort !");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0} à gagné le combat", NameHero);
                Console.ResetColor();
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public static void Combat()
        {
            Console.WriteLine("Zbeub Zbeub le combat");
        }
    }
}
