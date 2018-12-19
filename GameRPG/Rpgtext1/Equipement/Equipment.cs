using System;
namespace GameRPG
{
    public class Equipment
    {
        #region variable 

        public string Name;
        public string Description;
        public int Value;
        public int x;
        public int y;

        #endregion

        public Equipment(string name, string descript, int v, int x, int y)
        {
            Name = name;
            Description = descript;
            Value = v;
            this.x = x;
            this.y = y;

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
