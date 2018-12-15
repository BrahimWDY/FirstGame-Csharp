using System;
namespace GameRPG
{
    public class Equipment
    {
        #region variable 

        public string Name;
        public string Description;
        public float Value;
        public float Weight;

        #endregion

        public Equipment(string name, string descript, float v, float w)
        {
            Name = name;
            Description = descript;
            Value = v;
            Weight = w;
        }

        // Afficher un objet
        public void Print()
        {
            Console.WriteLine(Name + " : " + Description);
        }

        // Ramasser un objet
        public virtual void PickUp()
        {
            Console.WriteLine("Vous ramassez : " + Name);
        }

        // Utiliser un objet 
        public virtual void Use()
        {
            Console.WriteLine("Vous utilisez : " + Name);
        }
    }
}
