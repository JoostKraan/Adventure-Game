using AdventureGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregame
{
     class Game
     {
        public void GameStart(int characterselect)
        {
            switch (characterselect)
            {
                case 1:
                    Console.SetCursorPosition(130, 0);
                    Console.WriteLine("You are an Archer");
                break;
                case 2:
                    Console.SetCursorPosition(130, 0);
                    Console.WriteLine("You are a Sorcerer");
                    break;
                case 3:
                    Console.SetCursorPosition(130, 0);
                    Console.WriteLine("You are an Warrior");
                    break;
            }
            Console.ReadLine();





        } 
     }
}
