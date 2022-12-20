using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregame
{
    class Weapons
    {
        public string name { get; set; }
        public int damage { get; set; }
        public int durability { get; set; }

        public Weapons (string name, int damage, int durability)
        {
            this.name = name;
            this.damage = damage;
            this.durability = durability;
        }
        
        class Spells //WIP
        {
            public string name { get; set; }
            public int damage { get; set; }
            public float time { get; set; }



        }
        





    }
    
    
}
