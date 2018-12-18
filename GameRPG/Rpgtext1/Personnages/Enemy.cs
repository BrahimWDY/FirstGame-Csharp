using System;
namespace GameRPG.Personnages
{
    public class Enemy : Personnage
    {

        #region Constructeur

        public Enemy(string name, int attack, int health, int X, int Y)
        {
            Name = name;
            Attack = attack;
            Health = health;
            x = X;
            y = Y;

        }



        #endregion

    }
}
