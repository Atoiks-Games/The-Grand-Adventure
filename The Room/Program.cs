using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace The_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            const int fudgeFactor = 1;
            string nameFirst = "";
            string nameLast = "";
            string nameCheck = "";
            string race = "";
            string adventuringClass = "";
            int health = 0;
            int level = 0;
            int resistance = 0;
            int damageMod = 0;

            Random rnd = new Random();
            int strength = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            int dexterity = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            int constitution = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            int intelligence = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            int wisdom = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            int charisma = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;


            WriteLine("Your strength is: " + strength);
            WriteLine("Your dexterity is: " + dexterity);
            WriteLine("Your constitution is: " + constitution);
            WriteLine("Your intelligence is: " + intelligence);
            WriteLine("Your wisdom is: " + wisdom);
            WriteLine("Your charisma is: " + charisma);

            while (nameCheck != "y") {
                WriteLine("What is your first name adventurer? ");
                nameFirst = ReadLine();
                WriteLine("What is your last name adventurer? ");
                nameLast = ReadLine();
                WriteLine("Your name is: " + nameFirst + " " + nameLast + ". Is this correct? (y/n)");
                nameCheck = ReadLine().ToLower();
                if (!(nameCheck == "n" || nameCheck == "y"))
                {
                    WriteLine("INVALID! TRY AGAIN!");
                };
            };

        Race:
            WriteLine("What race do you wish to be? Write the first letter!");
            WriteLine("Dwarf: +2 Con, +1 Str, -1 Dex");
            WriteLine("Human: +2 Cha, +1 Str, -1 Wis");
            WriteLine("Elf: +2 Int, +1 Dex, -1 Con");
            WriteLine("Gnome: +2 Dex, +1 Cha, -1 Str");
            WriteLine("Infernal: +2 Wis, +1 Int, -1 Cha");
            WriteLine("Lizardfolk: +2 Str, +1 Con, -1 Cha");
            race = ReadLine().ToLower();
            switch (race)
            {
                case "d":
                    constitution = constitution + 2;
                    strength = strength + 1;
                    dexterity = dexterity - 1;
                    race = "Dwarf";
                    WriteLine("You are now a dwarf! Diggy Diggy Hole!");
                    break;
                case "h":
                    charisma = charisma + 2;
                    strength = strength + 1;
                    wisdom = wisdom - 1;
                    race = "Human";
                    WriteLine("You are now a human! Yay!");
                    break;
                case "e":
                    intelligence = intelligence + 2;
                    dexterity = dexterity + 1;
                    constitution = constitution - 1;
                    race = "Elf";
                    WriteLine("You are now an elf! A very popular choice...");
                    break;
                case "g":
                    dexterity = dexterity + 2;
                    charisma = charisma + 1;
                    strength = strength - 1;
                    race = "Gnome";
                    WriteLine("You are now a gnome! How cute!");
                    break;
                case "i":
                    wisdom = wisdom + 2;
                    intelligence = intelligence + 1;
                    charisma = charisma - 1;
                    race = "Infernal";
                    WriteLine("You are now an infernal! Is it me or is it getting hot in here?");
                    break;
                case "l":
                    strength = strength + 2;
                    constitution = constitution + 1;
                    charisma = charisma - 1;
                    race = "Lizardfolk";
                    WriteLine("You are now a lizardfolk. Hisssssssss...");
                    break;
                default:
                WriteLine("Ye dun goofed!");
                goto Race;
            }
        
            WriteLine("Your new strength is: " + strength);
            WriteLine("Your new dexterity is: " + dexterity);
            WriteLine("Your new constitution is: " + constitution);
            WriteLine("Your new intelligence is: " + intelligence);
            WriteLine("Your new wisdom is: " + wisdom);
            WriteLine("Your new charisma is: " + charisma);

        AdventuringClass:
            WriteLine("Great! Your name is: {0} {1}. You race is: {2}. Now what class of adventurer are you?", nameFirst, nameLast, race);
            WriteLine("Again, write the first letter of the class you want!");
            WriteLine("Warrior");
            WriteLine("Ranger");
            WriteLine("Mage");
            WriteLine("Theif");
            adventuringClass = ReadLine().ToLower();
            switch (adventuringClass)
            {
                case "w":
                    constitution = constitution + 1;
                    strength = strength + 1;
                    adventuringClass = "Warrior";
                    WriteLine("You are a warrior! Enemies shall fear your mighty sword!");
                    resistance = constitution + level;
                    damageMod = (strength - 10) * level;
                    break;
                case "r":
                    wisdom = wisdom + 1;
                    dexterity = dexterity + 1;
                    adventuringClass = "Ranger";
                    WriteLine("You are now a ranger! Enemies shall fear your piercing arrows!");
                    resistance = dexterity + level;
                    damageMod = (strength - 10) * level;
                    break;
                case "m":
                    intelligence = intelligence + 1;
                    wisdom = wisdom + 1;
                    adventuringClass = "Mage";
                    WriteLine("You are now a mage! Enemies shall fear your arcanic powers!");
                    resistance = constitution + level;
                    damageMod = (intelligence - 10) * level;
                    break;
                case "t":
                    dexterity = dexterity + 1;
                    charisma = charisma + 1;
                    adventuringClass = "Theif";
                    WriteLine("You are now a theif! Enemies shall fear your deadly daggers!");
                    resistance = dexterity + level;
                    damageMod = (charisma - 10) * level;
                    break;
                default:
                    WriteLine("Ye dun goofed!");
                    goto AdventuringClass;
            }
            WriteLine("Great! Your name is: {0} {1}. You race is: {2}. Your adventuring class is: {3}", nameFirst, nameLast, race, adventuringClass);
            level = 1;
            WriteLine("You are now level 1!");
            health = level * constitution;
            WriteLine("Your health is {0}.", health);
            WriteLine("Your resistance is {0}.", resistance);
            WriteLine("Your damage modifier is {0}", damageMod);
            WriteLine("Your base damage is {0}-{1}", level, level * 6);
            WriteLine("Let us begin!");

            WriteLine("Press Enter To Exit Program.");
            Read();

        }
    }
}
