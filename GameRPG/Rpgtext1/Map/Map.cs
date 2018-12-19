using System;
using System.Collections.Generic;
using GameRPG.Equipement;
using GameRPG.Personnages;

namespace GameRPG
{
    public class Map
    {
        public static int Largeur;
        public static int Longueur;
        public int NbCases;
        public string nom;
        public static Case[,] Plateau;



        public Map(int largeur, int longeur)
        {
            Largeur = largeur;
            Longueur = longeur;
            Plateau = new Case[Largeur, Longueur];


            // Je parcours ma map en longueur et en largeur 
            for (int i = 0; i < Largeur; i++)
            {
                for (int j = 0; j < Longueur; j++)
                {
                    Plateau[i, j] = new Case(i, j, Case.CaseType.Mur, "Mur");
                }
            }




        }

        // Je crée une fonction qui me permet de montrer la map et d'afficher le joueur dessus
        public void ShowMap(Player player, Enemy enemy)
        {

            for (int j = 0; j < Longueur; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < Largeur; i++)

                {
                    if (Plateau[i, j].player == player)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("[ M ] ");
                        Console.ResetColor();
                    }
                    else if (Plateau[i, j].Type == Case.CaseType.Mur)
                    {
                        Console.Write("[ * ] ");
                    }
                    else if (Plateau[i, j].Type == Case.CaseType.enemy)
                    {
                        Console.Write("[ * ] ");
                    }
                }
            }
        }


        public void SpawnEnemy(Enemy enemy, int x, int y)
        {
            if (LimitMapX(x) && LimitMapY(y))
            {
                enemy.x = x;
                enemy.y = y;
                Plateau[x, y] = new Case(x, y, Case.CaseType.enemy, "mur");
                Plateau[x, y].enemy = enemy;
                //ShowMap(player);
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Oops.. Tu ne peux pas traverser le mur !");
                Console.ResetColor();

            }

        }

        public void SpawnPotion(Equipment potion, int x, int y)
        {
            potion.x = x;
            potion.y = y;

        }

        // je crée un fonction qui me permet de faire spawn mon player sur la map
        //i et j prennent les valeurs précédentes de x et y
        public void SpawnPlayer(Player player, int x, int y, int i, int j)
        {
            // notre joueur est placé au coordonnée x, y et on sauvegarde les coprdonnées dans player.x player.y



            if (LimitMapX(x) && LimitMapY(y))
            {
                player.x = x;
                player.y = y;
                Plateau[x, y].player = player;
                Plateau[i, j] = new Case(i, j, Case.CaseType.Mur, "mur");
                //ShowMap(player);
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Oops.. Tu ne peux pas traverser le mur !");
                Console.ResetColor();

            }

        }




        //public string GetDescription(int x, int y)
        //{
        //    return Plateau[x,y].Description;
        //}


        // je fais un teste pour retourner une erreur lorsque mon joueur arrive à la limite de la map 
        public static bool LimitMapX(int x)
        {
            if (x <= 0 || x >= Largeur - 1)
            {

                return false;
            }

            else
            {
                return true;
            }

        }

        public static bool LimitMapY(int y)
        {
            if (y <= 0 || y >= Longueur - 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }



        public void GameMap(Map map, Player player, Enemy enemy, Potion potion)
        {

            while (true)
            {

                if (player.x == enemy.x && player.y == enemy.y)
                {
                    Console.Clear();
                    Fight.StartFight(player, enemy, "", map);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    player.PlayerStats(player, player.Attack, player.Health);
                    map.ShowMap(player, enemy);
                    player.PlayerMove(map, enemy);

                    Console.WriteLine();
                }

                if (player.x == potion.x && player.y == potion.y)
                {
                    Console.WriteLine("Tu as trouvé un {0}", potion.Name);
                    Console.WriteLine(potion.Description);
                    Console.WriteLine("\n1 - Consommer");
                    Console.WriteLine("2 - Ranger dans le sac");
                    Console.WriteLine("\nVotre choix : ");

                    int choice = Menu.AskChoice(1, 2);

                    switch (choice)
                    {
                        case 1:
                            if (potion.Type == Potion.PotionType.Heal)
                            {
                                player.Health += potion.Value;
                                Console.WriteLine("Votre niveau de vie est de : " + player.Health);
                                potion = null;
                                Console.WriteLine("Appuyez sur 'Entrer' pour continuer.");
                                Console.ReadLine();
                                Console.Clear();

                                while (true)
                                {

                                    Console.Clear();
                                    Console.WriteLine();
                                    player.PlayerStats(player, player.Attack, player.Health);
                                    map.ShowMap(player, enemy);
                                    player.PlayerMove(map, enemy);

                                    Console.WriteLine();

                                }
                            }
                            else if (potion.Type == Potion.PotionType.Attack)
                            {
                                player.Attack += potion.Value;
                                Console.WriteLine("Votre niveau de force est de : " + player.Attack);
                                potion = null;
                                Console.WriteLine("Appuyez sur 'Entrer' pour continuer.");
                                Console.ReadLine();
                                Console.Clear();

                                while (true)
                                {

                                    Console.Clear();
                                    Console.WriteLine();
                                    player.PlayerStats(player, player.Attack, player.Health);
                                    map.ShowMap(player, enemy);
                                    player.PlayerMove(map, enemy);

                                    Console.WriteLine();

                                }
                            }
                            break;

                        case 2:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Tu n'as pas de sac.\n");
                            Console.ResetColor();
                            break;

                        default:
                            break;
                    }

                }

            }
        }


    }
}
