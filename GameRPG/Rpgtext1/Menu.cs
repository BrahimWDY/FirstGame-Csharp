﻿using System;
using System.Collections.Generic;
using System.Threading;
using GameRPG.Equipement;
using GameRPG.Personnages;

namespace GameRPG
{
    public class Menu
    {
        // Constructeur
        public Menu()
        {
            PrintMenu();
            int choice = AskChoice(1, 4);
            switch (choice)
            {
                case 1:
                    StartGame();
                    break;

                case 2:
                    Load();
                    break;

                case 3:
                    About();
                    break;

                case 4:
                    Quit();
                    break;

                default:
                    break;
            }

        }


        // Afficher le menu
        public void PrintMenu()
        {
                Console.WriteLine("========== MENU ==========\n");
                Console.WriteLine("1 - Create New Game");
                Console.WriteLine("2 - Load Saved Game");
                Console.WriteLine("3 - About");
                Console.WriteLine("4 - Exit\n");
        }

        // le choix de l'utilisateur 
        public static int AskChoice(int min, int max)
        {
    
            int result = int.Parse( Console.ReadLine() );

            // Il faut faut le choix de l'utilisateur soit entre le min et le max sinon on reste dans la boucle 
            while (result > max || result < min)
            {
                Console.WriteLine("Entrez une valeur valide : ");
                result = int.Parse(Console.ReadLine());
            }
            return result;

        }

        // lancer le jeu
        public void StartGame()
        {

            // Je fais une condition pour retourner les fonctionnalités en fonction du choix de l'utilisateur
            string NameHero = "";

            while (true)
            {
                bool nomNotEmpty = true;
                while (nomNotEmpty)
                {
                    Console.WriteLine("\nVeuillez entrer votre nom : ");
                    NameHero = Console.ReadLine().ToUpper();
                    if (!(string.IsNullOrEmpty(NameHero)))
                    {
                        nomNotEmpty = false;
                    }
                }

                break;

            }

            // j'instencie ma map 
            Map map = new Map(7,7);

            // on instancie l'objet player (Nom, point d'attaque, point de vie)
            Player player = new Player(NameHero, 5, 20, 1, 1);



            Console.Clear();

            // on affiche les informations concernant le joueur

            player.PlayerStats(player, player.Attack, player.Health);


            Console.WriteLine("================================================================================================================");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("SYNOPSIS\n");
            Console.WriteLine("\nVous êtes un étudiant au sein de YNOV CAMPUS. Après plusieurs mois de cours,vous avez un coup de coeur sur \nune fille de votre campus qui s'appelle Léa.");
            Console.WriteLine("\nMalheureusement elle n'est jamais seule. Elle est toujours accompagnée de sa meilleur amie Alexia, et parfois \nde ses prétendants.");
            Console.WriteLine("\nLe but du jeu c'est d'éliminer tout ses prétendants, et battre sa meilleur amie pour atteindre Léa.");
            Console.WriteLine("\nAméliorez votre force d'attaque en utilisant des boissons et en vainquant vos ennemies.");
            Console.WriteLine("\nVous pouvez aussi améliorer votre santé ou vous soignez en mangeant des gâteaux.");
            Console.WriteLine("\nBON JEU!");
            Console.WriteLine("================================================================================================================");

            Console.WriteLine("Appuyez sur 'Entrer' pour continuer.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(@"         _._._                       _._._
        _|   |_                     _|   |_
        | ... |_._._._._._._._._._._| ... |
        | ||| |  o YNOV CAMPUS o  | ||| |
        | """""" |  """"""    """"""    """"""  | """""" |
   ())  |[-|-]| [-|-]  [-|-]  [-|-] |[-|-]|  ())
  (())) |     |---------------------|     | (()))
 (())())| """""" |  """"""    """"""    """"""  | """""" |(())())
 (()))()|[-|-]|  :::   .-""-.   :::  |[-|-]|(()))()
 ()))(()|     | |~|~|  |_|_|  |~|~| |     |()))(()
    ||  |_____|_|_|_|__|_|_|__|_|_|_|_____|  ||
 ~ ~^^ @@@@@@@@@@@@@@/=======\@@@@@@@@@@@@@@ ^^~ ~
      ^~^~                                ~^~^

");
            Console.WriteLine("=================================================");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Jeudi 20 Décembre 2018 : 8h40...");
            Console.ResetColor();
            Console.WriteLine("\nVous êtes à l'entrée du Campus.");
            Console.WriteLine("Vous avez cours de C# avec Monsieur JANIN Loic.");
            Console.WriteLine("Allez en salle 407 pour assister au cours.");
            Console.WriteLine("Elle se trouve à l'EST.");
            Console.WriteLine("=================================================\n");

            Console.WriteLine("\nAppuyez sur 'Entrer' pour continuer.");
            Console.ReadLine();
            Console.Clear();

           

            // Je crée une liste d'ennemi (Nom, point d'attaque, point de vie)
            List<Enemy> ints = new List<Enemy>();

            // je crée les différents ennemis 
            Enemy enemy = new Enemy("Kim", 5, 15, 2, 1);
            Enemy enemy1 = new Enemy("Sumeet", 3, 9, 2, 2);
            Enemy enemy2 = new Enemy("Adrien", 6, 11, 1, 3);
            Enemy enemy3 = new Enemy("Manu Garnier", 7, 18, 3, 4);
            Enemy enemy4 = new Enemy("Charif", 9, 22, 5, 3);
            Enemy enemy5 = new Enemy("Alexandra La BOSSFINAL", 10, 50, 6, 6);

            // et j'ajoute les ennemis 
            ints.Add(enemy);
            ints.Add(enemy1);
            ints.Add(enemy2);
            ints.Add(enemy3);
            ints.Add(enemy4);
            ints.Add(enemy5);

            // Spawn ennemies 


            map.SpawnEnemy(enemy,  2, 1);
            map.SpawnEnemy(enemy1, 2, 2);
            map.SpawnEnemy(enemy2, 1, 3);
            map.SpawnEnemy(enemy3, 3, 4);
            map.SpawnEnemy(enemy4, 5, 3);
            map.SpawnEnemy(enemy5, 5, 5);


            // Tableau d'information du PNJ 

            string[] infos = { "Il faudra battre Alexandra pour atteindre Léa !", "Tu deviendra plus fort en combattant t'es concurrents.", "Alexandra se trouve dans le souk." };


            //Tableau potion du PNJ

            List<Potion> pot = new List<Potion>();

            // je crée les différents potions
            Potion potion0 = new Potion("Coca Cola", "Augmente les points d'attaque de +5.", 5, Potion.PotionType.Attack, 1, 2);
            Potion potion1 = new Potion("Arizona", "Augmente les points d'attaque de +6.", 6, Potion.PotionType.Attack, 5, 1);
            Potion potion2 = new Potion("Kinder Bueno", "Augmente les points de vie de +6.", 6, Potion.PotionType.Heal, 1, 5);
            Potion potion3 = new Potion("Cookies", "Augmente les points de vie de +7.", 7, Potion.PotionType.Heal, 4, 4);

            // et j'ajoute les ennemis 
            pot.Add(potion0);
            pot.Add(potion1);
            pot.Add(potion2);
            pot.Add(potion3);

            //Potion[] potion = { potion0, potion1, potion2, potion3 };

            map.SpawnPotion(potion0, 1, 2);
            map.SpawnPotion(potion1, 5, 1);
            map.SpawnPotion(potion2, 1, 5);
            map.SpawnPotion(potion3, 4, 4);

            // je les ajoutes a mon tableau 
            Potion[] potion = { potion0, potion1, potion2, potion3 };


            // On met le joueur dans la map
            map.SpawnPlayer(player, 1, 1, 0, 0);

            // J'affiche la map

            map.GameMap(map, player, enemy, potion0);
           
        }

        public void Load()
        {
            Console.WriteLine("Momentanément indisponible...");
            Console.WriteLine("Appuyez sur 'Entrer' pour continuer.");
            Console.ReadLine();
            Console.Clear();
            Menu menu = new Menu();
        }

        public void About()
        {
            Console.WriteLine(@" _____   _____   _     _   _____   _       _____   _____   _____   _____  
|  _  \ | ____| | |   / / | ____| | |     /  _  \ |  _  \ |  _  \ | ____| 
| | | | | |__   | |  / /  | |__   | |     | | | | | |_| | | |_| | | |__   
| | | | |  __|  | | / /   |  __|  | |     | | | | |  ___/ |  ___/ |  __|  
| |_| | | |___  | |/ /    | |___  | |___  | |_| | | |     | |     | |___  
|_____/ |_____| |___/     |_____| |_____| \_____/ |_|     |_|     |_____| ");
        
            Console.WriteLine(@" _____       ___   _____   
|  _  \     /   | |  _  \  
| |_| |    / /| | | |_| |  
|  ___/   / / | | |  _  /  
| |      / /  | | | | \ \  
|_|     /_/   |_| |_|  \_\ ");


            Console.WriteLine(@" _____   _____        ___   _   _   _       ___  ___  
|  _  \ |  _  \      /   | | | | | | |     /   |/   | 
| |_| | | |_| |     / /| | | |_| | | |    / /|   /| | 
|  _  { |  _  /    / / | | |  _  | | |   / / |__/ | | 
| |_| | | | \ \   / /  | | | | | | | |  / /       | | 
|_____/ |_|  \_\ /_/   |_| |_| |_| |_| /_/        |_| ");

            Console.WriteLine(@" _____   _   _       ___   _____    _____        ___   _____   _  
/  _  \ | | | |     /   | |  _  \  |  _  \      /   | |  _  \ | | 
| | | | | | | |    / /| | | |_| |  | |_| |     / /| | | | | | | | 
| | | | | | | |   / / | | |  _  /  |  _  /    / / | | | | | | | | 
| |_| | | |_| |  / /  | | | | \ \  | | \ \   / /  | | | |_| | | | 
\_____/ \_____/ /_/   |_| |_|  \_\ |_|  \_\ /_/   |_| |_____/ |_| ");

            Console.WriteLine("\n Appuyez sur 'Entrer' pour continuer.");
            Console.ReadLine();
            Console.Clear();
            Menu menu = new Menu();

        }

        public void Quit()
        {
            Environment.Exit(0);
        }


    }
}
