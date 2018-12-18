using System;
using GameRPG.Personnages;

namespace GameRPG
{
   
    public class Player : Personnage
    {

        public Map map;

        public Player(string name, int attack, int health, int x, int y)
        {
            Name = name;
            Attack = attack;
            Health = health;
            this.x = x;
            this.y = y;
        }


        // Déplacement du joueur 
        public void PlayerMove(Map map, Enemy enemy)
        {
            Console.WriteLine("\n1 - NORD");
            Console.WriteLine("2 - SOUTH");
            Console.WriteLine("3 - EAST");
            Console.WriteLine("4 - WEST");

            int choice = Menu.AskChoice(1,4);

            switch (choice)
            {

                case 1:
                    North(this, map, enemy);
                    break;

                case 2:
                    South(this, map, enemy);
                    break;

                case 3:
                    East(this, map, enemy);
                    break;

                case 4:
                    West(this, map, enemy);
                    break;

                default:
                    Console.WriteLine("Ce cas n'est pas prit en charge.");
                    break;
            }

        }

        // Aller au nord 
        public void North(Player player, Map map, Enemy enemy)
        {
            map.SpawnPlayer(player, player.x, player.y - 1, player.x, player.y);
            map.TestCase(player, enemy);

        }


        // aller au sud
        public void South(Player player, Map map, Enemy enemy)
        {
            map.SpawnPlayer(player, player.x, player.y + 1, player.x, player.y);
            map.TestCase(player, enemy);
        }

        // Aller a l'Est
        public void East(Player player, Map map, Enemy enemy)
        {
           map.SpawnPlayer(player, player.x - 1, player.y, player.x, player.y);
           map.TestCase(player, enemy);
        }

        // Aller a l'ouest
        public void West(Player player, Map map, Enemy enemy)
        {
            map.SpawnPlayer(player, player.x + 1, player.y, player.x, player.y);
            map.TestCase(player, enemy);
        }


        /* public void LevelUp()
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
         }*/

    }
}
