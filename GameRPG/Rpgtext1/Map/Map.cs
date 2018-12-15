using System;
namespace GameRPG
{
    public class Map
    {
        private int Largeur;
        private int Longueur;
        public int NbCases;
        public string nom;
        public Case[,] Plateau;
       


        public Map()
        {
            Largeur = 6;
            Longueur = 6;
            Plateau = new Case[Largeur, Longueur];


            // Je parcours ma map en longueur et en largeur 
            for (int i = 0; i < Largeur; i++)
            {
                for (int j = 0; j < Longueur; j++)
                {
                    Plateau[i, j] = new Case(i, j, Case.CaseType.Couloir, "Tu es dans le couloir !");
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (Plateau[i, j].Description == "Tu es dans le couloir !")
                    {
                        Console.Write("0 |");
                    }
                }
                Console.WriteLine();
            }
        }




        public string GetDescription(int x, int y)
        {
            string s = Plateau[x, y].Description;
            return s;
        }
    }
}
