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
        public int characterselect;
        Game game = new Game();
        Program program = new Program();
        public void Archer()
        {
            Console.Clear();
            Console.SetCursorPosition(130, 0);
            Console.WriteLine("Archer");
            Console.SetCursorPosition(80, 4);
            Console.WriteLine("The Archer is a class that specializes in ranged combat.");
            Console.SetCursorPosition(80, 6);
            Console.WriteLine("They wield a variety of weapons such as bows, crossbows, and slingshots, and use arrows as their projectiles.");
            Console.SetCursorPosition(80, 8);
            Console.WriteLine("While the Archer class excels at picking off enemies from a distance,");
            Console.SetCursorPosition(80, 10);
            Console.WriteLine("they may struggle against swarms of foes who can quickly close the gap.");
            Console.SetCursorPosition(80, 12);
            Console.WriteLine("As such, they must be careful when facing multiple enemies at once.");
            Console.SetCursorPosition(130, 18);
            Console.WriteLine("To select the Archer class press 1 . . . ");


            int confirmArch = Int32.Parse(Console.ReadLine()); 
            if (confirmArch == 1)
            {
                Console.Clear();
                characterselect = 1;
                game.GameStart(characterselect);
            }
        }
        public void Sorcerer()
        {
            Console.Clear();
            Console.SetCursorPosition(130, 0);
            Console.WriteLine("Sorcerer");
            Console.SetCursorPosition(80, 4);
            Console.WriteLine("The Sorcerer is a spell-casting class that specializes in unleashing devastating magical attacks.");
            Console.SetCursorPosition(80, 6);
            Console.WriteLine("While they do have a weapon for melee combat, they primarily rely on their magical abilities to defeat their foes.");
            Console.SetCursorPosition(80, 8);
            Console.WriteLine("Sorcerers draw their power from a resource known as mana,");
            Console.SetCursorPosition(80, 10);
            Console.WriteLine("which they can use to cast a variety of spells.");
            Console.SetCursorPosition(80, 12);
            Console.WriteLine("Over time, their mana will replenish, allowing them to continue casting spells in battle.");
            Console.SetCursorPosition(80, 14);
            Console.WriteLine("One of the strengths of the Sorcerer class is their ability to attack multiple enemies at once.");
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("However, they are not as effective in close-range combat against single targets,");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("so they must be careful in how they approach each battle.");
            Console.SetCursorPosition(130, 25);
            Console.WriteLine("To select the Sorcerer class press 1 . . . ");

            int confirmsorc = Int32.Parse(Console.ReadLine());
            if (confirmsorc == 1)
            {
                Console.Clear();
                characterselect = 2;
                game.GameStart(characterselect);
            }
        }
        public void Warrior()
        {
            Console.Clear();
            Console.SetCursorPosition(130, 0);
            Console.WriteLine("Warrior");
            Console.SetCursorPosition(80, 4);
            Console.WriteLine("The Warrior is a class that specializes in melee combat.");
            Console.SetCursorPosition(80, 6);
            Console.WriteLine("They wield a variety of weapons such as axes, swords, blunt weapons, and hammers,");
            Console.SetCursorPosition(80, 8);
            Console.WriteLine("and are skilled at using these weapons to devastating effect in battle.");
            Console.SetCursorPosition(80, 10);
            Console.WriteLine("The Warrior is known for their strength and resilience,");
            Console.SetCursorPosition(80, 12);
            Console.WriteLine("making them difficult to take down in combat.");
            Console.SetCursorPosition(80, 14);
            Console.WriteLine("They excel at facing single enemies, but with the right tools and techniques,");
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("they can effectively engage multiple foes at once.");
            Console.SetCursorPosition(130, 18);
            Console.WriteLine("To select the Warrior class press 1 . . . ");

            int confirmwarr = Int32.Parse(Console.ReadLine());
            if (confirmwarr == 1)
            {
                Console.Clear();
                Console.ReadLine();
                characterselect = 3;
                game.GameStart(characterselect);
            }
        }
    }
}
