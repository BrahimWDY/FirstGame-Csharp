using System;
namespace GameRPG
{
   
    public class Player : Personnage
    {
        public int x;
        public int y;

        public Player(string name, int attack, int health, int x, int y)
        {
            Name = name;
            Attack = attack;
            Health = health;
            this.x = x;
            this.y = y;
        }


        // Déplacement du joueur 
        public void PlayerMove()
        {
            Console.WriteLine("\n1 - NORD");
            Console.WriteLine("2 - SOUTH");
            Console.WriteLine("3 - EAST");
            Console.WriteLine("4- WEST");

            int choice = Menu.AskChoice(1,4);

            switch (choice)
            {

                case 1:
                    North(this);
                    break;

                case 2:
                    South(this);
                    break;

                case 3:
                    East(this);
                    break;

                case 4:
                    West(this);
                    break;

                default:
                    Console.WriteLine("Ce cas n'est pas prit en charge.");
                    break;
            }

        }

        // Aller au nord 
        public void North(Player player)
        {
            Map.SpawnPlayer(player, player.x, player.y - 1);
            Map.SpawnPlayer(player, player.x, player.y );

        }

        // aller au sud
        public void South(Player player)
        {
            Map.SpawnPlayer(player, player.x, player.y + 1);

        }

        // Aller a l'Est
        public void East(Player player)
        {
            Map.SpawnPlayer(player, player.x - 1, player.y);
        }

        // Aller a l'ouest
        public void West(Player player)
        {
            Map.SpawnPlayer(player, player.x + 1, player.y);
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
