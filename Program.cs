using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonWar.Creatures;


namespace DungeonWar
{
     class Program
    {
        static void Main(string[] args)
        {
            int run;


            Menu();

            switch (run = Convert.ToInt32(Console.ReadLine()))

            {
                
                case 1:                   
                    Banshee();
                    break;

                case 2:                 
                    Cyborg();
                    break;

                case 3:
                    Gobblin();
                    break;

                case 4:
                    Hydra();
                    break;

                case 5:
                    Minotaur();
                    break;

                case 6:
                    Troll();
                    break;

                    default:
                    Console.WriteLine("Error");
                    break;

            }
            while (true) ; // Temporary



            static void Banshee()
            {
                Console.Clear();
                Banshee banshee = new Banshee();
                banshee.Level = 1;
                banshee.Health = 25;
                banshee.Mana = 10;
                string? answer;

                Console.Write("\n\tWhat is your name banshee? : ");
                banshee.Name = Console.ReadLine();

                Console.Write("\n\tPick you magic");

                Console.Write("\n\n\t1: for Fire or 2: for Air: ");
                switch (answer = Console.ReadLine().ToLower())
                {
                    case "1":
                        banshee.Magic = "Fire";
                        break;

                    case "2":
                        banshee.Magic = "Air";
                        break;

                    default:
                        break;
                }
                
                Console.ForegroundColor = ConsoleColor.Red;            

                Console.WriteLine("\n\tWelcome to Dungeon Wars: " + banshee.Name);
                Console.Write("\n\tCurrent Level is: " + banshee.Level);
                Console.Write("\n\tCurrent Health is: " + banshee.Health);
                Console.Write("\n\tCurrent Mana is: " + banshee.Mana);
                Console.Write("\n\tCurrent Magic is: " + banshee.Magic);
            }

            static void Cyborg()
            {
                Console.Clear();
                Cyborg cyborg = new Cyborg();
            }

            static void Gobblin()
            {
                Console.Clear();
                Gobblin gobblin = new Gobblin();
            }

            static void Hydra()
            {
                Console.Clear();
                Hydra hydra = new Hydra();
            }

            static void Minotaur()
            {
                Console.Clear();
                Minotaur minotaur = new Minotaur();
            }

            static void Troll()
            {
                Console.Clear();
                Troll troll = new Troll();
                Console.Write("\tWhat is your name troll? : ");
                troll.Name = Console.ReadLine();

                Console.Write("Hello", troll.Name);
                Console.Write("", troll.Level);
            }

            static void Menu()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tHello Stranger!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t");
                Console.WriteLine("\n\tWhat kind of creature do you want to create?");
                Console.Write("\n\t1: Banshee");
                Console.Write("\t2: Cyborg");
                Console.Write("\t3: Gobblin");
                Console.Write("\t4: Hydra");
                Console.Write("\t5: Minotaur");
                Console.Write("\t6: Troll");
                Console.Write("\n\n\tChoose one of the numbers: ");
            }
        }

    }
}