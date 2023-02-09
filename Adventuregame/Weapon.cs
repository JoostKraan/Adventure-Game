using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adventuregame
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Durability { get; set; }

        public Weapon(string Name, int Damage, int Durability)
        {
            Name = Name;
            Damage = Damage;
            Durability = Durability;

            List<Weapon> weapons = new List<Weapon>();
            string[] lines = File.ReadAllLines(@"E:\projects\Adventure - Game\Files\Weapons.txt");
            return;
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                int damage = int.Parse(parts[1]);
                int durability = int.Parse(parts[2]);
                weapons.Add(new Weapon(name, damage, durability));
            }
        }        
    }
}
