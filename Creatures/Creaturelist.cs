using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWar.Creatures
{
    public class Creaturelist
    {   
        public class CreatureStats
        {
            private int Level;
            private int Health;
            private int Energy;          
            public CreatureStats(int level, int health, int energy)
            {
                Level = level;
                Health = health;
                Energy = energy;              
            }

            public int level
            {
                get { return Level; }
                set { Level = value; }
            }

            public int health
            {
                get { return Health; }
                set { Health = value; }
            }
            public int energy
            {
                get { return Energy; }
                set { Energy = value; }
            }
        }

        public class CreatureScarab
        {

        }

        public class CreatureWasp
        {

        }

        public class CreatureDragon
        {

        }

        public class CreatureBalrog
        {

        }

        public class CreatureWitch
        {

        }

        public class CreatureShaman
        {

        }
        public class CreatureLizzard
        {

        }
        public class CreatureDemon
        {

        }
        public class CreatureGhost
        {

        }
        public class CreatureFireElement
        {

        }
        public class CreatureBioElement
        {

        }
        public class CreatureGiant
        {

        }
        public class CreaturePirate
        {

        }
        public class CreatureGoblin
        {

        }
        public class CreatureGnome
        {

        }
        public class CreatureOrc
        {

        }
        public class CreatureSorcerer
        {

        }
        public class CreatureCultist
        {

        }

    }
}
