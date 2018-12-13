using System;
namespace JeuRPG
{
    public class HeroRPG
    {

 // je limite les choix de mon utilisateur 
        public enum HeroJob { Guerrier, Villageois, Chevalier};

        public string nom;
        public HeroJob job;
        private int PointDeVie;
        private int force;
        private int endurance;
        private float taille;


        public HeroRPG(string NomPlayer, HeroJob work)
        {
            nom = NomPlayer;
            job = work;

            InitialisationHero(job);
        }

        // Je crée mes heros et leurs compétences 

        public void InitialisationHero( HeroJob job )
        {
            switch (job)
            {
                case HeroJob.Guerrier:
                    PointDeVie = 100;
                    force = 156;
                    endurance = 72;
                    taille = 190;
                    break;

                case HeroJob.Villageois:
                    PointDeVie = 100;
                    force = 50;
                    endurance = 23;
                    taille = 178;
                    break;

                case HeroJob.Chevalier:
                    PointDeVie = 100;
                    force = 138;
                    endurance = 56;
                    taille = 185;
                    break;
            }
        }

        // Je crée une fonction qui gère les dégats du hero 

        public int Damage( int degats )
        {
            PointDeVie -= degats;
            if ( PointDeVie <= 0 )
            {
                Console.WriteLine("DEAD !");
            }

            return PointDeVie;

        }


        public static HeroRPG WhosTheBest(HeroRPG h1, HeroRPG h2)
        {
            if (h1.force > h2.force)
            {
                return h1;

            }else
            {
                return h2;
            }
        }


    }
}

