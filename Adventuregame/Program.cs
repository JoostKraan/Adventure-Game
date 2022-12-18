using Adventuregame;
using System;
using System.Security.Cryptography;

namespace AdventureGame
{
    public class Program
    {
        public static Characterinfo charInfo = new Characterinfo();
        static void Main(string[] args)
        {
            while (true)
             {
                Console.Clear();
                Console.SetCursorPosition(130, 0);
                Console.WriteLine("Adventure Game?\n ");
                Console.SetCursorPosition(130, 4);
                Console.WriteLine("1 : Play \n");
                Console.SetCursorPosition(130, 8);
                Console.WriteLine("2 : Help \n");
                Console.SetCursorPosition(130, 12);
                Console.WriteLine("3 : Exit to windows \n");
                
                int userinput = Int32.Parse(Console.ReadLine());

                switch (userinput) //menu logic 
                {
                    case 1:
                        Console.Clear();
                        GameMenu();
                        break;
                    case 2:
                        Console.Clear();
                        Help();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        Console.ReadLine();
                        break;
                }
             }
            static void GameMenu()
            {
                Characterinfo character = new Characterinfo();
                Console.SetCursorPosition(130, 0);
                Console.WriteLine("Choose your Class . . .");
                Console.SetCursorPosition(130, 5);
                Console.WriteLine("1:\t Archer");
                Console.SetCursorPosition(130, 8);
                Console.WriteLine("2: \t Sorcerer");
                Console.SetCursorPosition(130, 11);
                Console.WriteLine("3: \t Warrior");
                Console.SetCursorPosition(130, 15);
                int classinput = Int32.Parse(Console.ReadLine());

                switch (classinput)
                {
                    case 1:
                        character.Archer();
                        break;
                    case 2:
                        character.Sorcerer();
                        break;
                    case 3:
                        character.Warrior();
                        break;
                        default :
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            static void Help()
            {
                Console.SetCursorPosition(65, 0);
                Console.WriteLine("Need help? ");
                Console.SetCursorPosition(40, 4);
                Console.WriteLine("To navigate in this game, you can use the keyboard and the numbered menu options");
                Console.SetCursorPosition(40, 6);
                Console.WriteLine("(1, 2, 3, etc.). When you start the game,");
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("you can choose from three classes: Archer, Sorcerer, and Warrior.");
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("Each class has its own unique abilities that affect how the game is played.");
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("The rest of the game is currently under development.");
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("To go back to the Main menu : Press any key...");
                Console.ReadLine();
            }
        }
    }
}
