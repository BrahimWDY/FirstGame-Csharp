using System;
using GameRPG.Personnages;

namespace GameRPG
{
   
    public class Player : Personnage
    {

        public Player(string name, int attack, int health, int x, int y)
        {
            Name = name;
            Attack = attack;
            Health = health;
            this.x = x;
            this.y = y;
        }


        public void PlayerStats(Player player, int attack, int health)
        {
            Console.WriteLine("\n================================================================================================================\n");
            Console.SetCursorPosition(0, 3);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Player : " + player.Name);
            Console.SetCursorPosition(50, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Health : " + player.Health);
            Console.SetCursorPosition(102, 3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Force : " + player.Attack);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n================================================================================================================\n");
        }

        // Déplacement du joueur 
        public void PlayerMove(Map map, Enemy enemy)
        {
            Console.WriteLine("\n\n1 - NORD");
            Console.WriteLine("2 - SOUTH");
            Console.WriteLine("3 - WEST");
            Console.WriteLine("4 - EAST");
            Console.WriteLine("\nVotre choix : ");

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
            //map.TestCase(player, enemy);
            map.SpawnPlayer(player, player.x, player.y - 1, player.x, player.y);

        }


        // aller au sud
        public void South(Player player, Map map, Enemy enemy)
        {
           // map.TestCase(player, enemy);
            map.SpawnPlayer(player, player.x, player.y + 1, player.x, player.y);
        }

        // Aller a l'Est
        public void East(Player player, Map map, Enemy enemy)
        {
            //map.TestCase(player, enemy);
            map.SpawnPlayer(player, player.x - 1, player.y, player.x, player.y);
           
        }

        // Aller a l'ouest
        public void West(Player player, Map map, Enemy enemy)
        {
           // map.TestCase(player, enemy);
            map.SpawnPlayer(player, player.x + 1, player.y, player.x, player.y);

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
