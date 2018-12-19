using System;
using GameRPG.Equipement;
using GameRPG.Personnages;

namespace GameRPG
{
    public class Case
    {
        public enum CaseType { Couloir, Fika, Souk, Classe, Mur, enemy };

        public int X;
        public int Y;
        public CaseType Type;
        public string Description;

        public Enemy enemy;
        public Equipment Item;
        public Player player;
        //private Potion Item;

        public Case(int x, int y, CaseType t, string D)
        {
            X = x;
            Y = y;
            Type = t;
            Description = D;
            player = null;
            Random r = new Random(DateTime.Now.Millisecond);

            // recuperer le prochain chiffre random et je fais %100 pour recuperer un chiffre entre 0 et 100 et si c'est supérieur a 50 = j'ai 50% de chance de trouver une potion 
            if (r.Next() % 100 > 50)
            {
              // Item = new Potion("Soin", "Potion de soin", 1, Potion.PotionType.Heal);
            }
            else
            {
                Item = null;
            }
        }

       
    }
}
