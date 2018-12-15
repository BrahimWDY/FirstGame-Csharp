using System;
using System.Collections.Generic;
using System.Threading;
using GameRPG.Personnages;

namespace GameRPG
{
    public class Menu
    {
        // Constructeur
        public Menu()
        {
            PrintMenu();
            int choice = AskChoice(0, 3);
            switch (choice)
            {
                case 0:
                    StartGame();
                    break;

                case 1:
                    Load();
                    break;

                case 2:
                    About();
                    break;

                case 3:
                    Quit();
                    break;

                default:
                    break;
            }

        }


        // Afficher le menu
        public void PrintMenu()
        {
                Console.WriteLine("========== MENU ==========\n");
                Console.WriteLine("0 - Create New Game");
                Console.WriteLine("1 - Load Saved Game");
                Console.WriteLine("2 - About");
                Console.WriteLine("3 - Exit\n");
                
            
        }

        // le choix de l'utilisateur 
        public static int AskChoice(int min, int max)
        {
            int result = int.Parse( Console.ReadLine() );

            // Il faut faut le choix de l'utilisateur soit entre le min et le max sinon on reste dans la boucle 
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;

        }

        // lancer le jeu
        public void StartGame()
        {

            // Je fais une condition pour retourner les fonctionnalités en fonction du choix de l'utilisateur
            string NameHero = "";

            while (true)
            {
                bool nomNotEmpty = true;
                while (nomNotEmpty)
                {
                    Console.WriteLine("\nVeuillez entrer votre nom : ");
                    NameHero = Console.ReadLine().ToUpper();
                    if (!(string.IsNullOrEmpty(NameHero)))
                    {
                        nomNotEmpty = false;
                    }
                }

                break;

            }

            // on instancie l'objet player (Nom, point d'attaque, point de vie)
            Player player = new Player(NameHero, 5, 20);


            Console.WriteLine(@"                                  .M
                                .:AMMO:
                       .:AMMMMMHIIIHMMM.
             ....   .AMMMMMMMMMMMHHHMHHMMMML:AMF""
           .:MMMMMLAMMMMMMMHMMMMMMHHIHHIIIHMMMML.
                ""WMMMMMMMMMMMMMMMMMMH:::::HMMMMMMHII:.
           .AMMMMMMMHHHMMMMMMMMMMHHHHHMMMMMMMMMAMMMHHHHL.
         .MMMMMMMMMMHHMMMMMMMMHHHHMMMMMMMMMMMMMHTWMHHHHHML
        .MMMMMMMMMMMMMMMMMMMHHHHHHHHHMHMMHHHHIII:::HMHHHHMM.
        .MMMMMMMMMMMMMMMMMMMMMMHHHHHHMHHHHHHIIIIIIIIHMHHHHHM.
        MMMMMMMMMMMMMMMMMHHMMHHHHHIIIHHH::IIHHII:::::IHHHHHHHL
        ""MMMMMMMMMMMMMMMMHIIIHMMMMHHIIHHLI::IIHHHHIIIHHHHHHHHML
         .MMMMMMMMMMMMMM""WMMMHHHMMMMMMMMMMMLHHHMMMMMMHHHHHHHHHHH
        .MMMMMMMMMMMWWMW   """"YYHMMMMMMMMMMMMF""""HMMMMMMMMMHHHHHHHH.
       .MMMMMMMMMM W"" V                         W""WMMMMMHHHHHHHHHH
      ""MMMMMMMMMM"".                                 ""WHHHMH""HHHHHHL
      MMMMMMMMMMF  .                                         IHHHHH.
      MMMMMMMMMM .                                  .        HHHHHHH
      MMMMMMMMMF. .                               .  .       HHHHHHH.
      MMMMMMMMM .     ,AWMMMMML.              ..    .  .     HHHHHHH.
    :MMMMMMMMM"".  .  F""'    'WM:.         ,::HMMA, .  .      HHHHMMM
    :MMMMMMMMF.  . .""         WH..      AMM""'     ""  .  .    HHHMMMM
     MMMMMMMM . .     ,;AAAHHWL""..     .:'                   HHHHHHH
     MMMMMMM:. . .   -MK""OTO L :I..    ...:HMA-.             ""HHHHHH
,:IIIILTMMMMI::.      L,,,,.  ::I..    .. K""OTO""ML           'HHHHHH
LHT::LIIIIMMI::. .      '""""'.IHH:..    .. :.,,,,           '  HMMMH: HLI'
ILTT::""IIITMII::.  .         .IIII.     . '""""""""             ' MMMFT:::.
HML:::WMIINMHI:::.. .          .:I.     .   . .  .        '  .M""'.....I.
""HWHINWI:.'.HHII::..          .HHI     .II.    .  .      . . :M.',, ..I:
 ""MLI""ML': :HHII::...        MMHHL     :::::  . :..      .'.'.'HHTML.II:
  ""MMLIHHWL:IHHII::....:I:"" :MHHWHI:...:W,,""  '':::.      ..'  "":.HH:II:
    ""MMMHITIIHHH:::::IWF""    """"""T99""'  '""""    '.':II:..'.'..'  I'.HHIHI'
      YMMHII:IHHHH:::IT..     . .   ...  . .    ''THHI::.'.' .;H."""".""H""
        HHII:MHHI""::IWWL     . .     .    .  .     HH""HHHIIHHH"":HWWM""
         """""" MMHI::HY""""ML,          ...     . ..  :""  :HIIIIIILTMH""
              MMHI:.'    'HL,,,,,,,,..,,,......,:"" . ''::HH ""HWW
              'MMH:..   . 'MMML,: """"""MM""""""""MMM""      .'.IH'""MH""
               ""MMHL..   .. ""MMMMMML,MM,HMMMF    .   .IHM""
                 ""MMHHL    .. ""MMMMMMMMMMMM""  . .  '.IHF'
                   'MMMML    .. ""MMMMMMMM""  .     .'HMF
                    HHHMML.                    .'MMF""
                   IHHHHHMML.               .'HMF""
                   HHHHHHITMML.           .'IF..
                   ""HHHHHHIITML,.       ..:F...
                    'HHHHHHHHHMMWWWWWW::""......
                      HHHHHHHMMMMMMF""'........
                       HHHHHHHHHH............
                         HHHHHHHH...........
                          HHHHIII..........
                           HHIII..........
                            HII.........
                             ""H........
                               ......");

            // on affiche les informations concernant le joueur
            Console.WriteLine("\n================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bonjour " + player.Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Votre niveau de vie est de : " + player.Health);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Votre force est de : " + player.Attack);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("================================\n");
            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine(@"         _._._                       _._._
        _|   |_                     _|   |_
        | ... |_._._._._._._._._._._| ... |
        | ||| |  o YNOV CAMPUS o  | ||| |
        | """""" |  """"""    """"""    """"""  | """""" |
   ())  |[-|-]| [-|-]  [-|-]  [-|-] |[-|-]|  ())
  (())) |     |---------------------|     | (()))
 (())())| """""" |  """"""    """"""    """"""  | """""" |(())())
 (()))()|[-|-]|  :::   .-""-.   :::  |[-|-]|(()))()
 ()))(()|     | |~|~|  |_|_|  |~|~| |     |()))(()
    ||  |_____|_|_|_|__|_|_|__|_|_|_|_____|  ||
 ~ ~^^ @@@@@@@@@@@@@@/=======\@@@@@@@@@@@@@@ ^^~ ~
      ^~^~                                ~^~^

");
            //TODO synopsis du jeu 

            // Je crée une liste d'ennemi (Nom, point d'attaque, point de vie)
            List<Enemy> ints = new List<Enemy>();

            // je crée les différents ennemis 
            Enemy enemy = new Enemy("Lucas Le charo 1", 5, 15);
            Enemy enemy1 = new Enemy("Jean Potter", 3, 9);
            Enemy enemy2 = new Enemy("Sarazin", 4, 11);
            Enemy enemy3 = new Enemy("Macron", 7, 18);
            Enemy enemy4 = new Enemy("Chuck Nouris", 9, 22);
            Enemy enemy5 = new Enemy("Alexandra La BOSSFINAL", 10, 50);

            // et j'ajoute les ennemis 
            ints.Add(enemy);
            ints.Add(enemy1);
            ints.Add(enemy2);
            ints.Add(enemy3);
            ints.Add(enemy4);
            ints.Add(enemy5);

        }

        public void Load()
        {

        }

        public void About()
        {
            Console.WriteLine(@" _____   _____   _     _   _____   _       _____   _____   _____   _____  
|  _  \ | ____| | |   / / | ____| | |     /  _  \ |  _  \ |  _  \ | ____| 
| | | | | |__   | |  / /  | |__   | |     | | | | | |_| | | |_| | | |__   
| | | | |  __|  | | / /   |  __|  | |     | | | | |  ___/ |  ___/ |  __|  
| |_| | | |___  | |/ /    | |___  | |___  | |_| | | |     | |     | |___  
|_____/ |_____| |___/     |_____| |_____| \_____/ |_|     |_|     |_____| ");
        
            Console.WriteLine(@" _____       ___   _____   
|  _  \     /   | |  _  \  
| |_| |    / /| | | |_| |  
|  ___/   / / | | |  _  /  
| |      / /  | | | | \ \  
|_|     /_/   |_| |_|  \_\ ");


            Console.WriteLine(@" _____   _____        ___   _   _   _       ___  ___  
|  _  \ |  _  \      /   | | | | | | |     /   |/   | 
| |_| | | |_| |     / /| | | |_| | | |    / /|   /| | 
|  _  { |  _  /    / / | | |  _  | | |   / / |__/ | | 
| |_| | | | \ \   / /  | | | | | | | |  / /       | | 
|_____/ |_|  \_\ /_/   |_| |_| |_| |_| /_/        |_| ");

            Console.WriteLine(@" _____   _   _       ___   _____    _____        ___   _____   _  
/  _  \ | | | |     /   | |  _  \  |  _  \      /   | |  _  \ | | 
| | | | | | | |    / /| | | |_| |  | |_| |     / /| | | | | | | | 
| | | | | | | |   / / | | |  _  /  |  _  /    / / | | | | | | | | 
| |_| | | |_| |  / /  | | | | \ \  | | \ \   / /  | | | |_| | | | 
\_____/ \_____/ /_/   |_| |_|  \_\ |_|  \_\ /_/   |_| |_____/ |_| ");

        }

        public void Quit()
        {

        }


    }
}
