using System;
namespace GameRPG.Personnages
{
    public class Enemy : Personnage
    {

        #region Constructeur

        public Enemy(string name, int attack, int health)
        {
            Name = name;
            Attack = attack;
            Health = health;

        }



        #endregion

    }
}
