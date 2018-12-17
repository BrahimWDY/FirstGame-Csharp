using System;
namespace GameRPG.Personnages
{
    public class PNJ : Personnage
    {
        private string Information;
        private bool GiveInfo;
        public string[] infos;
        public Equipment[] potions;

        public PNJ(string[] info, Equipment[] potions)
        {
            infos = info;
            this.potions = potions;

            Random choice = new Random(DateTime.Now.Millisecond);

            //TODO recuperer le prochain chiffre random et je fais %100 pour recuperer un chiffre entre 0 et 100 et si c'est supérieur a 50 = j'ai 50% de chance de trouver une potion 
            if (choice.Next() % 100 > 50)
            {
                GiveInfo = true;
            }
            else
            {
                GiveInfo = false;
            }
        }

        // Recupérer l'info et la retourner 
        public string[] getInfo()
        {
            return infos;
        }

        // Récupérer l'item et le retourner 
        public Equipment[] getPotion()
        {
            return potions;
        }

        public void setInfos(string[] newInfo)
        {
            infos = newInfo;
        }

        // je créer une fonction qui permet au pnj de retourner soit une info soit un item 
        public object pnjGift()
        {
            if (GiveInfo == true)
            {
                // je crée un random qui me permettra de retourner une de mes 3 infos dans mon tableau infos
                Random info = new Random();
                int resultRandom;
                resultRandom = info.Next(1,4);

                // Je fais les conditions necessaire pour retourner les infos
                if (resultRandom == 1 )
                {
                    return infos[0];
                }
                else if (resultRandom == 2)
                {
                    return infos[1];
                }
                else
                {
                    return infos[2];
                }



            }
            else
            {
                // je crée un random qui me permettra de retourner une de mes 4 potions de mon tableau
                Random itemPNJ = new Random();
                int resultRandom1;
                resultRandom1 = itemPNJ.Next(1,5);

                // Je fais les conditions necessaire pour retourner les potions 

                if (resultRandom1 == 1)
                {
                    return potions[1];
                }
                else if (resultRandom1 == 2)
                {
                    return potions[2];
                }
                else if (resultRandom1 == 3)
                {
                    return potions[3];
                }
                else
                {
                    return potions[4];
                }
            }
        }



    }
}
