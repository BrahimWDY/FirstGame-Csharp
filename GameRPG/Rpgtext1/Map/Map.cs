using System;
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
                    Plateau[i, j] = new Case(i, j, Case.CaseType.Mur, "Oops.. Tu ne peux pas traverser le mur !");
                }
            }

          


        }

        // Je crée une fonction qui me permet de montrer la map et d'afficher le joueur dessus
        public static void ShowMap(Player player)
        {
            for (int j = 0; j < Longueur; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < Largeur; i++)

                {
                    if (Plateau[i, j].player == player)
                    {
                        Console.Write("P ");
                    }
                    else if (Plateau[i, j].Type == Case.CaseType.Mur)
                    {
                        Console.Write("* ");
                    }

                }
            }
        }

        // je crée un fonction qui me permet de faire spawn mon player sur la map
        public static void SpawnPlayer(Player player, int x, int y)
        {
            // notre joueur est placé au coordonnée x, y et on sauvegarde les coprdonnées dans player.x player.y
            Plateau[x, y].player = player;
            player.x = x;
            player.y = y;

            ShowMap(player);

        }


        public string GetDescription(int x, int y)
        {
            return Plateau[x,y].Description;
        }
    }
}
