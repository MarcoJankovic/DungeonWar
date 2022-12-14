using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWar.Characters
{
    public class Stats
    {
        private int level;
        private string? name;
        private string? magic;
        private int energy;
        private int health;
        private int mana;
        private int damage;
        private string? strength;
        private int gold;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public string? Magic
        {
            get { return magic; }
            set { magic = value; }
        }

        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public string? Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }

    }

}
