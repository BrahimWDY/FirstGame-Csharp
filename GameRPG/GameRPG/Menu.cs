using System;
using System.Collections.Generic;
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

            // on instancie l'objet player 
            Player player = new Player(NameHero, 20);


            // on affiche les informations concernant le joueur 
            Console.WriteLine("Bonjour " + player.Name + "\n" + "Votre niveau de vie : " + player.Health + " pv");

            //TODO synopsis du jeu 

            // Je crée une liste d'ennemi
            List<Enemy> ints = new List<Enemy>();

            // je crée les différents ennemis 
            Enemy enemy = new Enemy("Lucas Le charo 1", 15);
            Enemy enemy1 = new Enemy("Jean Potter", 9);
            Enemy enemy2 = new Enemy("Sarazin", 11);
            Enemy enemy3 = new Enemy("Macron", 18);
            Enemy enemy4 = new Enemy("Chuck Nouris", 22);
            Enemy enemy5 = new Enemy("Alexandra La BOSSFINAL", 50);

            // et j'ajoute les ennemis 
            ints.Add(enemy);
            ints.Add(enemy1);
            ints.Add(enemy2);
            ints.Add(enemy3);
            ints.Add(enemy4);
            ints.Add(enemy5);

        }

        public void Load()
        {

        }

        public void About()
        {
            Console.WriteLine("Développé par Brahim Ouarradi.");
        }

        public void Quit()
        {

        }


    }
}
