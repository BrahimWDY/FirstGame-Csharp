using System;
namespace GameRPG.Equipement
{
    public class Potion : Equipment
    {
        public enum PotionType { Heal, Attack };
        public PotionType Type;


        public Potion(string name, string descript, float v, float w, PotionType t)
            : base(name, descript, v, w)

        {
            Type = t;
        }

        // override veut dire je veux pas utiliser PickUp du pere mais celle du fils 
        public override void PickUp()
        {
            // base c'est celui du pere 
            base.PickUp();
            Console.WriteLine("Vous avez une nouvelle confiserie");
        }

        public override void Use()
        {
            base.Use();
            Console.WriteLine("Vous avez utilisé une confiserie");
        }
    }
}
