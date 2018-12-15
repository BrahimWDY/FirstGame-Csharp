using System;
namespace GameRPG
{
    public class Equipment
    {
        #region variable 

        public string Name;
        public string Description;
        public float Value;

        #endregion

        public Equipment(string name, string descript, float v)
        {
            Name = name;
            Description = descript;
            Value = v;
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
