using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregame
{
    class Inventory
    {
        List<Weapon> Weapons = new List<Weapon>()
        {
            new Weapon("Shortsword", 5, 15),
            new Weapon("Dagger", 3, 20),
            new Weapon("Warhammer", 6, 21),
            new Weapon("Staff", 1, 10),
            new Weapon("Longbow", 2, 15),
            new Weapon("Crossbow", 5, 10)
        };
        List<Spell> Spells = new List<Spell>()
        {
            new Spell("FireBolt", 3, 5, 0),
            new Spell("FireBurn", 2, 5, 2)
        };
        public List<Weapon> GetWeapons()
        {
            return Weapons;
        }
        public List<Spell> GetSpells()
        {
            return Spells;
        }



    }

    class Weapon
    {
        public string name { get; set; }
        public int damage { get; set; }
        public int durability { get; set; }

        public Weapon(string name, int damage, int durability)
        {
            this.name = name;
            this.damage = damage;
            this.durability = durability;
        }
    }
    class Spell //WIP
    {
        public string name { get; set; }
        public int damage { get; set; }
        public int range { get; set; }
        public int dot { get; set; }
        public Spell(string name, int damage, int range, int dot)
        {
            this.name = name;
            this.damage = damage;
            this.range = range;
            this.dot = dot;
        }
    }
}