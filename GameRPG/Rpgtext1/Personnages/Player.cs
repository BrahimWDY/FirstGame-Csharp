using System;
namespace GameRPG
{
   
    public class Player : Personnage
    {
        #region Constructeur

        public Player(string N, int H)
        {
            Name = N;
            Health = H;

        }



        #endregion
    }
}
