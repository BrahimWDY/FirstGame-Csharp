using System;
namespace GameRPG.Equipement
{
    public class Potion : Equipment
    {
        public enum PotionType { Heal, Attack };
        public PotionType Type;


        public Potion(string name, string descript, float v, PotionType t)
            : base(name, descript, v)

        {
            Type = t;
        }


        public override void PickUp()
        {
            // base c'est celui du pere 
            base.PickUp();
            Console.WriteLine("Vous avez une nouvelle confiserie");
        }

        public override void Use()
        {
            base.Use();
            Console.WriteLine("Vous avez mangé une confiserie");
        }
    }
}
