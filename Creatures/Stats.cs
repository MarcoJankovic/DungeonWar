using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWar.Creatures
{
    public class Stats
    {
        private int level;
        private string? name;
        private string? magic;
        private int health;
        private int mana;
        private int damage;

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

    }

}
