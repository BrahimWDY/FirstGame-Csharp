using System;
using GameRPG.Personnages;

namespace GameRPG
{
    public class Fight
    {
       

        public static void StartFight(Player player, Enemy enemy, string NameHero, Map map)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("TU AS CROISE UN DE T'ES CONCURRENT !! DETRUIT LE. ");
            Console.ResetColor();

            player.PlayerStats(player, player.Attack, player.Health);
            enemy.EnemyStats(enemy, enemy.Attack, enemy.Health);


            bool PlayerTurn = true;

            while (true)
            {

                if (PlayerTurn == true)
                {
                    Console.WriteLine("\n========== PLAYER TURN ==========");
                    Console.WriteLine();
                    Console.WriteLine("1 - ATTAQUER L'ENNEMI");
                    Console.WriteLine("2 - SE SOIGNER");
                    Console.WriteLine("3 - FUIR");

                    int choice = Menu.AskChoice(1, 3);

                    switch (choice)
                    {
                        case 1:
                            enemy.Health -= player.Attack;
                            Console.WriteLine("\n{0} lui reste {1} points de vie ! ", enemy.Name, enemy.Health);
                            if (enemy.Health <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("l'ennemi est mort !");
                                Console.ResetColor();
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("{0} à gagné le combat", player.Name);
                                Console.ResetColor();

                                enemy = null;

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

                            PlayerTurn = false;

                            if (PlayerTurn == false)
                            {
                                player.Health -= enemy.Attack;
                                Console.WriteLine();
                                Console.WriteLine("\n========== ENEMY TURN ==========");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n{0} vous a infligé {1} de dégats", enemy.Name, player.Attack);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Il vous reste {0} points de vie", player.Health);
                                Console.ResetColor();
                                if (player.Health <= 0)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("TU AS ECHOUE !");
                                    Console.WriteLine("TU FERAS MIEUX LA PROCHAINE FOIS !");
                                    Console.ResetColor();
                                    Console.WriteLine("Appuyez sur 'Entrer' pour continuer.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Menu menu = new Menu();
                                }

                                PlayerTurn = true;
                            }



                            Console.WriteLine("Appuyez sur 'Entrer' pour continuer.");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                         case 2:
                            Console.WriteLine("Vous n'avez aucune potion dans votre inventaire car je l'ai pas créer...");
                            break;
                             
                        case 3:
                            Console.WriteLine("Tu reste dans le combat et tu te bat comme un homme !");
                            break; 


                        default:
                            break;
                    }

                }


            }


        }



    }
}
