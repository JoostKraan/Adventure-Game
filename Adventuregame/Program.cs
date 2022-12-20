using Adventuregame;
using System;
using System.Security.Cryptography;

namespace AdventureGame
{

    public static class Program
    {
        public static Characterinfo charInfo = new Characterinfo();
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(85, 0);
                Console.WriteLine("Adventure Game?\n ");
                Console.SetCursorPosition(85, 4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 : Play \n");
                Console.SetCursorPosition(85, 8);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("2 : Help \n");
                Console.SetCursorPosition(85, 12);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 : Exit to windows \n");
                int userInput = Int32.Parse(Console.ReadLine());
                switch (userInput) //menu logic 
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
                        Console.WriteLine("Invalid Input");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public static void GameMenu() // Class selection case 
        {
            Characterinfo character = new Characterinfo();
            Console.SetCursorPosition(80, 0);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Choose your Class . . .");
            Console.SetCursorPosition(80, 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1:\t Archer");
            Console.SetCursorPosition(80, 8);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2: \t Sorcerer");
            Console.SetCursorPosition(80, 11);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("3: \t Warrior");
            Console.SetCursorPosition(80, 15);
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
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        public static void Help() // explanation about game (will be changed around) needs explanation about spells and weapons
        {
            Console.SetCursorPosition(85, 0);
            Console.WriteLine("Need help? ");
            Console.SetCursorPosition(75, 4);
            Console.WriteLine("To navigate in this game, you can use the keyboard and the numbered menu options");
            Console.SetCursorPosition(75, 6);
            Console.WriteLine("(1, 2, 3, etc.). When you start the game,");
            Console.SetCursorPosition(75, 8);
            Console.WriteLine("you can choose from three classes: Archer, Sorcerer, and Warrior.");
            Console.SetCursorPosition(75, 10);
            Console.WriteLine("Each class has its own unique abilities that affect how the game is played.");
            Console.SetCursorPosition(75, 12);
            Console.WriteLine("The rest of the game is currently under development.");
            Console.SetCursorPosition(75, 18);
            Console.WriteLine("To go back to the Main menu : Press any Enter . . . ");
            Console.ReadLine();
        }
        public static void GameConfig(int characterselect, Player player) // User enters their player infomation. class and name.
        {
            if (characterselect == 1)
            {
                Console.SetCursorPosition(85, 4);
                Console.WriteLine("I have chosen to be an Archer.");
                Console.SetCursorPosition(85, 6);
                Console.WriteLine("And what am I going to be called?");
                string playerName = Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(85, 4);
                Console.WriteLine($"You can call me {playerName} the Archer");
                Console.SetCursorPosition(85, 6);
                Console.WriteLine("Press Enter to continue . . . ");
                Console.ReadLine();
                Gamestart(characterselect, playerName);
            }
            else if (characterselect == 2)
            {
                Console.SetCursorPosition(85, 4);
                Console.WriteLine("I have chosen to be a Sorcerer");
                Console.SetCursorPosition(85, 6);
                Console.WriteLine("And what am I going to be called?");
                string playerName = Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(85, 4);
                Console.WriteLine($"You can call me {playerName} the Sorcerer");
                Console.SetCursorPosition(85, 6);
                Console.WriteLine("Press Enter to continue . . . ");
                Console.ReadLine();
                Gamestart(characterselect, playerName);
            }
            else if (characterselect == 3)
            {
                Console.SetCursorPosition(85, 4);
                Console.WriteLine("I have chosen to be a Warrior");
                Console.SetCursorPosition(85, 6);
                Console.WriteLine("And what am I going to be called?");
                string playerName = Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(85, 4);
                Console.WriteLine($"You can call me {playerName} the Warrior");
                Console.SetCursorPosition(85, 6);
                Console.WriteLine("Press Enter to continue . . . ");
                Console.ReadLine();
                Gamestart(characterselect,playerName);
            }
        }
        public static void Gamestart(int characterselect,string playerName) // most actions happen here, weapon selection and main adventures (might be getting some changes changed?)
        {
            Console.Clear();
            Console.SetCursorPosition(70, 2);
            Console.WriteLine("You start out with these base stats for your character.");
            Console.SetCursorPosition(70, 4);
            Console.WriteLine($"Name : {playerName}");
            Console.SetCursorPosition(70, 6);
            Console.WriteLine($"Health : {Characterinfo.player.Health}");
            Console.SetCursorPosition(70, 8);
            Console.WriteLine($"Stamina : {Characterinfo.player.Stamina}");
            if (characterselect == 1)
            {
                Console.SetCursorPosition(70, 10);
                Console.WriteLine($"Arrows : {Characterinfo.player.Arrows}");
                Weapons dagger = new Weapons("Dagger", 1, 10);
                Weapons longbow = new Weapons("Longbow", 2, 15);
                Weapons crossbow = new Weapons("Crossbow", 5, 10);
                Console.SetCursorPosition(70, 20);
                Console.WriteLine($"Weapon 1 : {dagger.name} (Short-ranged Melee weapon)");
                Console.SetCursorPosition(70, 25);
                Console.WriteLine($"Weapon 2: {longbow.name}(Long-range Accurate bow)");
                Console.SetCursorPosition(70, 30);
                Console.WriteLine($"Weapon 3 : {crossbow.name}(Medium-range Strong Bow)");
                Console.SetCursorPosition(70, 32);
                Console.WriteLine("I seem to have 3 weapon choices to help me through my journey. . . ");
                Console.SetCursorPosition(70, 34);
                Console.WriteLine("It looks like there is a Dagger, Longbow and a Crossbow laying infront of me.");
                Console.SetCursorPosition(70, 36);
                Console.WriteLine("A Dagger is great choice for close-quarter combat");
                Console.SetCursorPosition(70, 38);
                Console.WriteLine("But that bow would be amazing to use against enemies from a longer range.");
                Console.SetCursorPosition(70, 40);
                Console.WriteLine("Or if I want to sacrifice range an accuracy for strenght then i should go for the Crossbow.");
                Console.SetCursorPosition(70, 44);
                Console.WriteLine("Choose an option with 1, 2 and 3 ");
                Console.SetCursorPosition(70, 46);
                int weaponSelection = Int32.Parse(Console.ReadLine());
                switch (weaponSelection)
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("I grabbed the Dagger so i can attack my enemies from a close range");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("I took the Longbow so i can defeat my enemies from a distance");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("I decided to take the Crossbow with me since that weapon- ");
                        Console.SetCursorPosition(70, 4);
                        Console.WriteLine("does the most amount of damage against my enemies");
                        break;
                }       
            }
            if (characterselect == 2) 
            {
                Console.SetCursorPosition(70, 10);
                Console.WriteLine($"Mana : {Characterinfo.player.Mana}");
                Spells fireBolt = new Spells("FireBolt", 3, 5, 0);
                Spells fireBurn = new Spells("FireBurn", 2, 5, 2);
                Weapons Staff = new Weapons("Staff", 1, 10);
                Console.SetCursorPosition(50, 20);
                Console.WriteLine($"Spell 1 : {fireBolt.name} (Direct Attack spell that does a medium amount of damage on impact of an enemy)");//maybe look for more original names for spells
                Console.SetCursorPosition(50, 25);
                Console.WriteLine($"Spell 2 : {fireBurn.name} (Spell does a small amount of damage on impact but does more damage overtime)");
                Console.SetCursorPosition(50, 30);
                Console.WriteLine($"Weapon 3: {Staff.name} (A melee weapon for close range combat, not very strong. Best to use as secondary weapon)");
                Console.SetCursorPosition(50, 35);
                Console.WriteLine("It looks like i have 2 Spell options and one melee weapon that i can use for my adventure.");
                Console.SetCursorPosition(50, 37);
                Console.WriteLine("I've got two spellbooks containing a Firebolt Spell and a Firburn Spell and a staff.");
                Console.SetCursorPosition(50, 39);
                Console.WriteLine("The Firebolt is always a good option since it's a spell that does a decent amount of damage and almost never fails to cast");
                Console.SetCursorPosition(50, 41);
                Console.WriteLine("The Fireburn is also a good option because of it does damage overtime which could help if there is an enemy chasing you!");
                Console.SetCursorPosition(50, 43);
                Console.WriteLine("And last there is a staff which can be used for melee attacks and maybe it could enhance my spellcasting skills later on . . .");
                Console.SetCursorPosition(50, 45);
                Console.WriteLine("Choose an option with 1, 2 and 3 ");
                
            }
            if (characterselect == 3)
                Console.WriteLine(Characterinfo.player.Stamina);
            Console.ReadLine();

            if (characterselect == 1)
            {
                
            }
            Console.WriteLine("test outside if");
        }
    }
}