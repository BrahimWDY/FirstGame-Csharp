using System;
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
            int choice = AskChoice(0, 3);
            switch (choice)
            {
                case 0:
                    StartGame();
                    break;

                case 1:
                    Load();
                    break;

                case 2:
                    About();
                    break;

                case 3:
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
                Console.WriteLine("0 - Create New Game");
                Console.WriteLine("1 - Load Saved Game");
                Console.WriteLine("2 - About");
                Console.WriteLine("3 - Exit\n");
                
            
        }

        // le choix de l'utilisateur 
        public static int AskChoice(int min, int max)
        {
            int result = int.Parse( Console.ReadLine() );

            // Il faut faut le choix de l'utilisateur soit entre le min et le max sinon on reste dans la boucle 
            while (result > max || result < min)
            {
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
            Map map = new Map();

            // on instancie l'objet player (Nom, point d'attaque, point de vie)
            Player player = new Player(NameHero, 5, 20);

            // On met le joueur dans la map
            map.SpawnPlayer(player);

            Console.Clear();

            // on affiche les informations concernant le joueur
            Console.WriteLine("\n================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bonjour " + player.Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Votre niveau de vie est de : " + player.Health);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Votre force est de : " + player.Attack);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("================================\n");

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

            Console.WriteLine("Synopsis du jeu");


            //TODO synopsis du jeu 

            // Je crée une liste d'ennemi (Nom, point d'attaque, point de vie)
            List<Enemy> ints = new List<Enemy>();

            // je crée les différents ennemis 
            Enemy enemy = new Enemy("Kim", 5, 15);
            Enemy enemy1 = new Enemy("Sumeet", 3, 9);
            Enemy enemy2 = new Enemy("Woody", 4, 11);
            Enemy enemy3 = new Enemy("Manu Garnier", 7, 18);
            Enemy enemy4 = new Enemy("Charif", 9, 22);
            Enemy enemy5 = new Enemy("Alexandra La BOSSFINAL", 10, 50);

            // et j'ajoute les ennemis 
            ints.Add(enemy);
            ints.Add(enemy1);
            ints.Add(enemy2);
            ints.Add(enemy3);
            ints.Add(enemy4);
            ints.Add(enemy5);


            // Tableau d'information du PNJ 

            string[] infos = new string[3] {"Il faudra battre Alexandra la BOSSFINAL pour pécho ta crush !", "Tu deviendra plus fort en combattant t'es concurrents.", "Alexandra se trouve dans le souk."};


            //Tableau potion du PNJ

            // je crée les différents potions
            Potion potion0 = new Potion("Coca Cola", "Augemente les points d'attaque de +5.", 5, Potion.PotionType.Attack);
            Potion potion1 = new Potion("Arizona", "Augemente les points d'attaque de +6.", 6, Potion.PotionType.Attack);
            Potion potion2 = new Potion("Kinder Bueno", "Augemente les points de vie de +6.", 6, Potion.PotionType.Heal);
            Potion potion3 = new Potion("Cookies", "Augemente les points de vie de +7.", 7, Potion.PotionType.Heal);

            // je les ajoutes a mon tableau 
            Potion[] potion = new Potion[4] { potion0, potion1, potion2, potion3 };
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

        }


    }
}
