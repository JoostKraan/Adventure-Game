using Adventuregame;
using System;
using System.Security.Cryptography;

namespace AdventureGame
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t \t \t \t \t \t Adventure Game? \n ");
            menu();

            void menu()
            {

                Console.WriteLine("\t \t \t \t \t \t \t \t 1: \t Play \n \n \t \t \t \t \t \t \t \t 2: \t Options  \n \n \t \t \t \t \t \t \t \t 3: \t Help \n \n \t \t \t \t \t \t \t \t 4: \t Exit to windows");
                while (true)
                 { 
                    Console.SetCursorPosition(65, 10);
                    int userinput = Int32.Parse(Console.ReadLine());

                    switch (userinput)
                    {
                        case 1:
                            Console.Clear();
                            Game();
                            break;
                        case 2:
                            Console.Clear();
                            Options();
                            break;
                        case 3:
                            Console.Clear();
                            Help();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                 }
            }
            void Game()
            {
                Characterinfo character = new Characterinfo();
                Console.SetCursorPosition(65, 0);
                Console.WriteLine("Choose your Class . . .");
                Console.SetCursorPosition(65, 5);
                Console.WriteLine("1:\t Archer");
                Console.SetCursorPosition(65, 8);
                Console.WriteLine("2: \t Sorcerer");
                Console.SetCursorPosition(65, 11);
                Console.WriteLine("3: \t Warrior");
                Console.SetCursorPosition(65, 15);
                

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
            void Options()
            {
                Console.WriteLine("Options");
            }
            void Help()
            {
                Console.WriteLine("Help");
            }
        }
    }
}
