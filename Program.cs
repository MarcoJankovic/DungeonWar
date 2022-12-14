using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonWar.Characters;
using DungeonWar.Creatures;
using static System.Net.Mime.MediaTypeNames;


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
                    Minotaur();
                    break;

                case 5:
                    Troll();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }

            /// ----------------------------------------------------------------------------------------------------///
            static void Banshee()
            {
                Console.Clear();
                Banshee banshee = new Banshee();
                banshee.Level = 1;
                banshee.Health = 25;
                banshee.Mana = 10;
                banshee.Damage = 5;
                banshee.Gold = 0;
                string? answer;

                Console.Write("\n\tWhat is your name banshee? : ");
                banshee.Name = Console.ReadLine();

                Console.Write("\n\tChoose your magic");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t1: for Fire \n\t2: for Air \n\t3: for Water \n\t4: for Nature \n\t5: for Chaos \n\t");
                switch (answer = Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        banshee.Magic = "Fire";
                        break;

                    case "2":
                        Console.Clear();
                        banshee.Magic = "Air";
                        break;

                    case "3":
                        Console.Clear();
                        banshee.Magic = "Water";
                        break;

                    case "4":
                        Console.Clear();
                        banshee.Magic = "Nature";
                        break;

                    case "5":
                        Console.Clear();
                        banshee.Magic = "Chaos";
                        break;

                    default:
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tWelcome to Dungeon Wars: " + banshee.Name);
                Console.Write("\n\tCurrent Level is: " + banshee.Level);
                Console.Write("\n\tCurrent Health is: " + banshee.Health);
                Console.Write("\n\tCurrent Mana is: " + banshee.Mana);
                Console.Write("\n\tCurrent Damage is: " + banshee.Damage);
                Console.Write("\n\tCurrent Magic is: " + banshee.Magic);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\tYour Wealth is: " + banshee.Gold + " Gold");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\tTo level up your creature, you have to enter the Dungeon!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\n\tPress 1: To enter Dungeon \n\tPress 2: To enter Market \n\tPress 3: To enter Rest-Area\n\t");
                RunDungeon();

            }
            /// ----------------------------------------------------------------------------------------------------///
            static void Cyborg()
            {
                Console.Clear();
                Cyborg cyborg = new Cyborg();
                cyborg.Level = 1;
                cyborg.Health = 25;
                cyborg.Energy = 10;
                cyborg.Damage = 5;
                cyborg.Gold = 0;
                string? answer;

                Console.Write("\n\tWhat is your name cyborg? : ");
                cyborg.Name = Console.ReadLine();

                Console.Write("\n\tChoose your Class");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t1: for Brute \n\t2: for Berserk \n\t3: for Warrior \n\t");
                switch (answer = Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        cyborg.Strength = "Brute";
                        break;

                    case "2":
                        Console.Clear();
                        cyborg.Strength = "Berserk";
                        break;

                    case "3":
                        Console.Clear();
                        cyborg.Strength = "Warrior";
                        break;

                    default:
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tWelcome to Dungeon Wars: " + cyborg.Name);
                Console.Write("\n\tCurrent Level is: " + cyborg.Level);
                Console.Write("\n\tCurrent Health is: " + cyborg.Health);
                Console.Write("\n\tCurrent Energy is: " + cyborg.Energy);
                Console.Write("\n\tCurrent Damage is: " + cyborg.Damage);
                Console.Write("\n\tCurrent Class is: " + cyborg.Strength);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\tYour Wealth is: " + cyborg.Gold + " Gold");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\tTo level up your creature, you have to enter the Dungeon!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\n\tPress 1: To enter Dungeon \n\tPress 2: To enter Market \n\tPress 3: To enter Rest-Area\n\t");
                RunDungeon();
            }
            /// ----------------------------------------------------------------------------------------------------///
            static void Gobblin()
            {
                Console.Clear();
                Gobblin gobblin = new Gobblin();
                gobblin.Level = 1;
                gobblin.Health = 25;
                gobblin.Energy = 10;
                gobblin.Damage = 5;
                gobblin.Gold = 0;
                string? answer;

                Console.Write("\n\tWhat is your name gobblin? : ");
                gobblin.Name = Console.ReadLine();

                Console.Write("\n\tChoose your class");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t1: for Assassin \n\t2: for Archer \n\t3: for Warrior \n\t");
                switch (answer = Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        gobblin.Strength = "Assassin";
                        break;

                    case "2":
                        Console.Clear();
                        gobblin.Strength = "Archer";
                        break;

                    case "3":
                        Console.Clear();
                        gobblin.Strength = "Warrior";
                        break;

                    default:
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tWelcome to Dungeon Wars: " + gobblin.Name);
                Console.Write("\n\tCurrent Level is: " + gobblin.Level);
                Console.Write("\n\tCurrent Health is: " + gobblin.Health);
                Console.Write("\n\tCurrent Energy is: " + gobblin.Energy);
                Console.Write("\n\tCurrent Damage is: " + gobblin.Damage);
                Console.Write("\n\tCurrent Class is: " + gobblin.Strength);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\tYour Wealth is: " + gobblin.Gold + " Gold");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\tTo level up your creature, you have to enter the Dungeon!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\n\tPress 1: To enter Dungeon \n\tPress 2: To enter Market \n\tPress 3: To enter Rest-Area\n\t");

                RunDungeon();

            }
        }
        /// ----------------------------------------------------------------------------------------------------///
        static void Minotaur()
        {
            Console.Clear();
            Minotaur minotaur = new Minotaur();
        }
        /// ----------------------------------------------------------------------------------------------------///
        static void Troll()
        {
            Console.Clear();
            Troll troll = new Troll();
            Console.Write("\tWhat is your name troll? : ");
            troll.Name = Console.ReadLine();
        }

        /// ----------------------------------------------------------------------------------------------------///
        static void RunDungeon()
        {

            string? answer;
            switch (answer = Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("\tEntering Dungeon\n\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Walking();
                    Console.Clear();
                    Console.WriteLine("\n\tYou sence danger!!\n\n");
                    GenerateRandomCreature();  // Create random creature
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n\tPress 1: Fight\n\tPress 2: Inspect\t\n\tPress 3: run\n\t");

                    switch (answer = Console.ReadLine())
                    {

                        case "1":
                            Console.Clear();
                            Console.Write("\n\n\tAre you sure you want to fight Y/N? ");
                            answer = Console.ReadLine();

                            if (answer == "Y" || answer == "y")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n\tPrepare to fight!");

                            }
                            else if (answer == "N" || answer == "n")
                            {
                                Console.WriteLine("\n\tYou run away!");
                            }
                            break;

                        case "2":
                            Console.Clear();
                            GenerateCreatureProperies();
                            Console.WriteLine("\n\tPress: B to go back");
                            answer = Console.ReadLine();
                            if (answer == "b" || answer == "B")
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tTo Late");
                            }
                            break;
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("\tEntering Market");
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("\tEntering Rest Area");
                    break;

                default:
                    break;
            }
            while (true) ; // Temporary
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tHello Stranger!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t");
            Console.WriteLine("\n\tWhat kind of champion do you want to create?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\t1: Banshee");
            Console.Write("\t2: Cyborg");
            Console.Write("\t3: Gobblin");
            Console.Write("\t4: Minotaur");
            Console.Write("\t5: Troll");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\n\tChoose one of the numbers: ");
        }

        static void Walking()
        {
            string head1 = " 0 ";
            string body1 = "!T!";
            string legs1 = "/ \\";
            string legs2 = " | ";
            bool legsShouldPrint = true;
            Console.WriteLine(head1);
            Console.WriteLine(body1);
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();
                int offset = i + 3;
                Console.WriteLine("\n\n");
                Console.WriteLine(head1.PadLeft(offset, ' ') + "");
                Console.WriteLine(body1.PadLeft(offset, ' ') + "\t-->");
                if (legsShouldPrint)
                {
                    Console.WriteLine(legs1.PadLeft(offset, ' '));
                }
                else
                {
                    Console.WriteLine(legs2.PadLeft(offset, ' ') + "");
                }
                legsShouldPrint = !legsShouldPrint;
                Thread.Sleep(40);
            }
        }

        static void GenerateRandomCreature() // Creates random enemy from the list
        {
            Random random = new Random();

            List<string> CreatureList = new List<string>
                {
                "Troll", "Scarab", "Wasp", "Dragon", "Balrog", "Witch", "Shaman", "Lizzard", "Demon", "Ghost",
                "Fire-Element", "Bio-Element", "Giant", "Pirate", "Goblin", "Gnome", "Orc", "Sorcerer", "Cultist"
                };

            string randomCreature = CreatureList[random.Next(0, CreatureList.Count)];

            Console.WriteLine($"\n\tA {randomCreature} approaches from the shadows\n");
            // randomCreature.Append(createLevel);  ????
        }

        static void GenerateCreatureProperies() // Gives the the troll creature random level and stats
        {
            List<Creaturelist.CreatureStats> CreatureProperties = new List<Creaturelist.CreatureStats>();

            Creaturelist.CreatureStats property1 = new Creaturelist.CreatureStats(1, 20, 10);
            Creaturelist.CreatureStats property2 = new Creaturelist.CreatureStats(2, 25, 15);
            Creaturelist.CreatureStats property3 = new Creaturelist.CreatureStats(3, 30, 20);
            Creaturelist.CreatureStats property4 = new Creaturelist.CreatureStats(4, 35, 25);

            CreatureProperties.Add(property1);
            CreatureProperties.Add(property2);
            CreatureProperties.Add(property3);
            CreatureProperties.Add(property4);

            Random newRandom = new Random();
            var createLevel = CreatureProperties[newRandom.Next(CreatureProperties.Count)];
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tCreature Stats:\n\n\tLevel: {0} \n\tHealth: {1} \n\tEnergy: {2}", createLevel.level, createLevel.health, createLevel.energy);
        }
    }
}
