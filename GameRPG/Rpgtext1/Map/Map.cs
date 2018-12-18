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
                    Plateau[i, j] = new Case(i, j, Case.CaseType.Mur, "Mur");
                }
            }

          


        }

        // Je crée une fonction qui me permet de montrer la map et d'afficher le joueur dessus
        public void ShowMap(Player player)
        {

            for (int j = 0; j < Longueur; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < Largeur; i++)

                {
                    if (Plateau[i, j].player == player)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("[ P ] ");
                        Console.ResetColor();
                    }
                    else if (Plateau[i, j].Type == Case.CaseType.Mur)
                    {
                        Console.Write("[ * ] ");
                    }

                }
            }
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


        public string GetDescription(int x, int y)
        {
            return Plateau[x,y].Description;
        }


        // je fais un teste pour retourner une erreur lorsque mon joueur arrive à la limite de la map 
        public static bool LimitMapX(int x)
        {
            if (x <= 0 || x >= Largeur - 1){

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
    }
}
