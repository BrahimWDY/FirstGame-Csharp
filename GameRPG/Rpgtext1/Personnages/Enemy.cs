using System;
namespace GameRPG.Personnages
{
    public class Enemy : Personnage
    {

       

        public Enemy(string name, int attack, int health, int X, int Y)
        {
            Name = name;
            Attack = attack;
            Health = health;
            x = X;
            y = Y;

        }

        public void EnemyStats(Enemy enemy, int attack, int health)
        {
            Console.WriteLine("\n================================================================================================================\n");
            Console.SetCursorPosition(0, 6);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enemy : " + enemy.Name);
            Console.SetCursorPosition(50, 6);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Health : " + enemy.Health);
            Console.SetCursorPosition(102, 6);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Force : " + enemy.Attack);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n================================================================================================================\n");
        }


    }
}
