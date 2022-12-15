using AdventureGame;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregame
{
    public class Characterinfo
    {
        Program program = new Program();
        public void Archer()
        {
            Console.Clear();
            Console.SetCursorPosition(65, 0);
            Console.WriteLine("Archer");
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("The Archer is a class that specializes in ranged combat.");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine("They wield a variety of weapons such as bows, crossbows, and slingshots, and use arrows as their projectiles.");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("While the Archer class excels at picking off enemies from a distance,");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("they may struggle against swarms of foes who can quickly close the gap.");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("As such, they must be careful when facing multiple enemies at once.");
            Console.ReadLine();
        }
        public void Sorcerer()
        {
            Console.Clear();
            Console.SetCursorPosition(65, 0);
            Console.WriteLine("Sorcerer");
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("The Sorcerer is a spell-casting class that specializes in unleashing devastating magical attacks.");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine("While they do have a weapon for melee combat, they primarily rely on their magical abilities to defeat their foes.");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Sorcerers draw their power from a resource known as mana,");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("which they can use to cast a variety of spells.");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Over time, their mana will replenish, allowing them to continue casting spells in battle.");
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("One of the strengths of the Sorcerer class is their ability to attack multiple enemies at once.");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("However, they are not as effective in close-range combat against single targets,");
            Console.SetCursorPosition(40, 18);
            Console.WriteLine("so they must be careful in how they approach each battle.");
            Console.SetCursorPosition(65, 13);
            Console.ReadLine();
        }
        public void Warrior()
        {
            Console.Clear();
            Console.SetCursorPosition(65, 0);
            Console.WriteLine("Warrior");
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("The Warrior is a class that specializes in melee combat.");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine("They wield a variety of weapons such as axes, swords, blunt weapons, and hammers,");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("and are skilled at using these weapons to devastating effect in battle.");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("The Warrior is known for their strength and resilience,");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("making them difficult to take down in combat.");
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("They excel at facing single enemies, but with the right tools and techniques,");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("they can effectively engage multiple foes at once.");
            Console.SetCursorPosition(65, 18);
            Console.ReadLine();

        }
    }

}
