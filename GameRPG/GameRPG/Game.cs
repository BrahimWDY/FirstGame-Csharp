using System;
namespace GameRPG
{
    public class Game
    {
        public Player player;
        public Map pateau;

        public Game()
        {
            //TODO faire le constructeur 
        }

        public void StartGame()
        {
            // TODO faire le début du jeu 
        }

        public void Deplacement()
        {
            //PrintChoix();
            int choix = Menu.AskChoice(0, 4);
            //TODO récupérer la case 
            //TODO Tester le contenu de la case
            //TODO peut etre lancer le combat...
        }

    }  
}
