using System;
namespace JeuRPG
{
    public class Histoire
    {
       
        // Je crée un menu afin que le joueur puisse choisir la fonctionnalité qu'il veut
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("========== MENU ==========\n");
                Console.WriteLine("1 - Create New Game");
                Console.WriteLine("2 - Load Saved Game");
                Console.WriteLine("3 - About");
                Console.WriteLine("4 - Exit\n");


                // L'utilisateur va saisir son choix et je le stock dans la variable indicePersoString puis ensuite je la convertie en int a fin de pouvoir effectuer ma condition
                int indicePerso = Convert.ToInt32( Console.ReadLine() );

                // Je fais une condition pour retourner les fonctionnalités en fonction du choix de l'utilisateur
                string NameHero = "";
                switch (indicePerso)
                {
                    case 1:

                        bool nomNotEmpty = true;
                        while(nomNotEmpty)
                        {
                            Console.WriteLine("\nVeuillez entrer votre nom : ");
                             NameHero = Console.ReadLine().ToUpper();
                            if( !(string.IsNullOrEmpty( NameHero ) ) ){
                                nomNotEmpty = false;
                            }
                        }
                        Console.WriteLine("\nBonjour " + NameHero);
                        Console.WriteLine("\nIl est 8h, vous venez de vous reveillez au milieu d'une fôret !");
                        Console.WriteLine("Vous devez survir et combattre tout les monstres que vous trouverez sur votre chemin pour gagner de l'expérience.");
                        Console.WriteLine("Pour terminer le jeu, il vous faudra battre le BOSS final !");
                        Console.WriteLine("Vous disposez d'un couteau dans votre sac.");
                        Console.WriteLine("Vous trouverez de nouvelles armes sur votre chemin.");
                        Console.WriteLine("Bonne chance !");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Pas encore disponible !");
                        break;

                    case 3:
                        Console.WriteLine("Jeu développé par Brahim Ouarradi");
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Commande inexistante !");
                        break;
                    }


                    

            } 

        } // Fin du Menu()

    }
}
