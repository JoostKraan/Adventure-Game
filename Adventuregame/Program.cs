using Adventuregame;
using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace AdventureGame
{

    public class Program
    {
        public static Inventory inventory = new Inventory();
        public List<Weapon> weapons = inventory.GetWeapons();
        public List<Spell> spells = inventory.GetSpells();
        public Characterinfo charInfo = new Characterinfo();
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(85, 5);
                Console.WriteLine("Adventure Game?\n ");
                Console.SetCursorPosition(85, 10);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("1 : Play \n");
                Console.SetCursorPosition(85, 14);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("2 : Help \n");
                Console.SetCursorPosition(85, 18);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 : Exit to windows \n");
                Console.SetCursorPosition(85,22);
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
            Console.SetCursorPosition(85, 5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Choose your Class . . .");
            Console.SetCursorPosition(85, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1: \t Archer");
            Console.SetCursorPosition(85, 14);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2: \t Sorcerer");
            Console.SetCursorPosition(85, 18);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("3: \t Warrior");
            Console.SetCursorPosition(85, 22);
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
            Console.WriteLine("To navigate in this game, you will only use the keyboard. You will mainly use the numbers 0-9 to go through menu's and select options.");
            Console.SetCursorPosition(75, 6);
            Console.WriteLine("There are three classes to choose from : The Archer, The Sorcerer and the Warrior.");
            Console.SetCursorPosition(75, 8);
            Console.WriteLine("Each class has different stats that you start out with. and each class has a different set of starter weapons.");
            Console.SetCursorPosition(75, 10);
            Console.WriteLine("The Sorcerer and the Archer have unique items that they can use : Mana and Arrows. these will be used to cast spells and shoot with your bow.");
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
                Gamestart(characterselect, playerName);
            }
        }
        public static void Gamestart(int characterselect, string playerName) // most actions happen here, weapon selection and main adventures (might be getting some changes changed?)
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
                Console.SetCursorPosition(50, 48);
                Console.WriteLine("Choose an option with 1, 2 and 3 ");
                int weaponselection = Int32.Parse(Console.ReadLine());
                switch (weaponselection)
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("I Chose to go with the Firebolt Spell since that does the most damage on impact.");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("I chose the Fireburn because I think that can help me the most when attacking enemies.");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("I have chosen the Staff,");
                        Console.SetCursorPosition(70, 4);
                        Console.WriteLine("It may be a melee weapon but if i obtain spells in the future it will increase my damage.");
                        Console.ReadLine();
                        break;
                }
            }
            if (characterselect == 3)
            {
                
                Console.SetCursorPosition(50, 20);
                Console.WriteLine($"Weapon 1 : {shortSword.name} (A quick melee weapon which is great for attacking single enemies)");
                Console.SetCursorPosition(50, 22);
                Console.WriteLine($"Weapon 2 : {dagger.name} (A small quick blade that does a small amount of damage)");
                Console.SetCursorPosition(50, 24);
                Console.WriteLine($"Weapon 3 : {warHammer.name} (A heavy melee weapon does a lot of damage but is very slow in attacking.");
                Console.SetCursorPosition(50, 26);
                Console.WriteLine("I seem to have 3 weapon choices laying infront of me");
                Console.SetCursorPosition(50, 28);
                Console.WriteLine("The Shortsword is a great choice for it being easy to handle, pretty quick ");
                Console.SetCursorPosition(50, 30);
                Console.WriteLine("The Dagger is a good option for its portability and quick attacks.");
                Console.SetCursorPosition(50, 32);
                Console.WriteLine("The Warhammer is an amazing choice for its high damage output but beware it has a slow speed.");
                Console.SetCursorPosition(50, 34);
                Console.WriteLine("Choose an option with 1, 2 and 3 ");
                int weaponSelection = Int32.Parse(Console.ReadLine());
                switch (weaponSelection)
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("I have chosen the Shortsword for quick medium power attacks.");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("I have chosen the dagger for its portablity and quick attacks");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("I've chosen the Warhammer so I can deal big amounts of damage to my enemies.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(70, 2);
                        Console.WriteLine("No valid input");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}