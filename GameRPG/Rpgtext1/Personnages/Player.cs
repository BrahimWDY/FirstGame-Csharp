using System;
namespace GameRPG
{
   
    public class Player : Personnage
    {


        public Player(string name, int attack, int health)
        {
            Name = name;
            Attack = attack;
            Health = health;

        }


        public void LevelUp()
        {
           

            Console.WriteLine("\n=============================");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FELICITATION !! VOUS AVEZ PASSE UN NIVEAU ");
            Console.WriteLine("Attaque + 5                               ");
            Console.WriteLine("PV + 10                                   ");
            Console.ResetColor();
            Console.WriteLine("=============================");


            Attack += 5;
            Health += 10;
        }

    }
}
