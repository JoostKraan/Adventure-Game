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
            Console.WriteLine("The Archer is a class that specialises in ranged Combat,");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine("They can use weapons such as an bow and arrow,Crossbows and slingshots and mainly use arrows as projectiles");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("You do have to be careful for swarms of enemies since they-");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("are not great at attacking multiple enemies at once.");
        }

        public void Sorcerer()
        {
            Console.Clear();
            Console.SetCursorPosition(65, 0);
            Console.WriteLine("Sorcerer");
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("The Sorcerer is a class that specialises in casting spells");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine("They have a weapon that they can use for melee attacks but mainly use spells");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Sorcerers use mana to use their spells, mana is a resource that they replenish over-time");
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("Sorceres are great at attacking multiple enemies at once but are weak at close-range and single enemies.\n");
            Console.SetCursorPosition(65, 13);
            Console.ReadLine();
        }

        public void Warrior()
        {
            Console.WriteLine("WIP");
        }

        public void backTomenu()
        {
            mainprogram
        }


    }

}
