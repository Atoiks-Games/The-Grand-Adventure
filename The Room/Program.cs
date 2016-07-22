using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace The_Room
{
    class Race
    {
        private static string raceName;
        public static string RaceName
        {
            get
            {
                return raceName;
            }
            set
            {
                raceName = value.ToUpper();
            }
        } 

    }

    class Class
    {
        private static string className;
        public static string ClassName
        {
            get
            {
                return className;
            }
            set
            {
                className = value.ToUpper();
            }
        }

    }

    class Scores
    {
        public static int str;
        public static int dex;
        public static int con;
        public static int intel;
        public static int wis;
        public static int cha;
        public static int playerNumber;

        public static void DisplayScores()
        {
            WriteLine("Your strength is: " + str);
            WriteLine("Your dexterity is: " + dex);
            WriteLine("Your constitution is: " + con);
            WriteLine("Your intelligence is: " + intel);
            WriteLine("Your wisdom is: " + wis);
            WriteLine("Your charisma is: " + cha);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            const int fudgeFactor = 1;
            string nameFirst = "";
            string nameLast = "";
            string nameCheck = "";
            string choice1 = "";
            int health = 0;
            int level = 1;
            int resistance = 0;
            int damageMod = 0;

            Random rnd = new Random();
            Scores.str = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            Scores.dex = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            Scores.con = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            Scores.intel = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            Scores.wis = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            Scores.cha = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;

            WriteLine("Welcome To:\n\n _The Grand Adventure_ \n\n Let's begin by determining your character's ability rankings and figuring out your name!");
            Scores.DisplayScores();

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
            switch (ReadLine().ToLower())
            {
                case "d":
                    Scores.con = Scores.con + 2;
                    Scores.str = Scores.str + 1;
                    Scores.dex = Scores.dex - 1;
                    Race.RaceName = "Dwarf";
                    WriteLine("You are now a dwarf! Diggy Diggy Hole!");
                    break;
                case "h":
                    Scores.cha = Scores.cha + 2;
                    Scores.str = Scores.str + 1;
                    Scores.wis = Scores.wis - 1;
                    Race.RaceName = "Human";
                    WriteLine("You are now a human! Yay!");
                    break;
                case "e":
                    Scores.intel = Scores.intel + 2;
                    Scores.dex = Scores.dex + 1;
                    Scores.con = Scores.con - 1;
                    Race.RaceName = "Elf";
                    WriteLine("You are now an elf! A very popular choice...");
                    break;
                case "g":
                    Scores.dex = Scores.dex + 2;
                    Scores.cha = Scores.cha + 1;
                    Scores.str = Scores.str - 1;
                    Race.RaceName = "Gnome";
                    WriteLine("You are now a gnome! How cute!");
                    break;
                case "i":
                    Scores.wis = Scores.wis + 2;
                    Scores.intel = Scores.intel + 1;
                    Scores.cha = Scores.cha - 1;
                    Race.RaceName = "Infernal";
                    WriteLine("You are now an infernal! Is it me or is it getting hot in here?");
                    break;
                case "l":
                    Scores.str = Scores.str + 2;
                    Scores.con = Scores.con + 1;
                    Scores.cha = Scores.cha - 1;
                    Race.RaceName = "Lizardfolk";
                    WriteLine("You are now a lizardfolk. Hisssssssss...");
                    break;
                default:
                WriteLine("Ye dun goofed!");
                goto Race;
            }

            Scores.DisplayScores();

            AdventuringClass:
            WriteLine("Great! Your name is: {0} {1}. You race is: {2}. Now what class of adventurer are you?", nameFirst, nameLast, Race.RaceName);
            WriteLine("Again, write the first letter of the class you want!");
            WriteLine("Warrior");
            WriteLine("Ranger");
            WriteLine("Mage");
            WriteLine("Theif");
            switch (ReadLine().ToLower())
            {
                case "w":
                    Scores.con = Scores.con + 1;
                    Scores.str = Scores.str + 1;
                    Class.ClassName = "Warrior";
                    WriteLine("You are a warrior! Enemies shall fear your mighty sword!");
                    resistance = Scores.con + level;
                    damageMod = (Scores.con - 10) * level;
                    break;
                case "r":
                    Scores.wis = Scores.wis + 1;
                    Scores.dex = Scores.dex + 1;
                    Class.ClassName = "Ranger";
                    WriteLine("You are now a ranger! Enemies shall fear your piercing arrows!");
                    resistance = Scores.dex + level;
                    damageMod = (Scores.str - 10) * level;
                    break;
                case "m":
                    Scores.intel = Scores.intel + 1;
                    Scores.wis = Scores.wis + 1;
                    Class.ClassName = "Mage";
                    WriteLine("You are now a mage! Enemies shall fear your arcanic powers!");
                    resistance = Scores.con + level;
                    damageMod = (Scores.intel - 10) * level;
                    break;
                case "t":
                    Scores.dex = Scores.dex + 1;
                    Scores.cha = Scores.cha + 1;
                    Class.ClassName = "Theif";
                    WriteLine("You are now a theif! Enemies shall fear your deadly daggers!");
                    resistance = Scores.dex + level;
                    damageMod = (Scores.cha - 10) * level;
                    break;
                default:
                    WriteLine("Ye dun goofed!");
                    goto AdventuringClass;
            }
            WriteLine("Great! Your name is: {0} {1}. You race is: {2}. Your adventuring class is: {3}", nameFirst, nameLast, Race.RaceName, Class.ClassName);
            WriteLine("You are now level 1!");
            health = level * Scores.con;
            WriteLine("Your health is {0}.", health);
            WriteLine("Your resistance is {0}.", resistance);
            WriteLine("Your damage modifier is {0}", damageMod);
            WriteLine("Your base damage is {0}-{1}", level, level * 6);
            WriteLine("Let us begin!");

            WriteLine("\n\n _CHAPTER 1: The Missing Merchant_ \n\n");
            WriteLine("You wake up. It's morning. You can hear the birds chirping and the nearby river flowing. You get out of bed and look around the tiny cabin you live in.");
            WriteLine("As you begin to get dressed you remeber that your adventuring contractor said he would be sending you a new task today. It would be in a parcel at the end of the long and twisted road to your house.");

            while (!(choice1 == "h")){
                WriteLine("You decide to:\nInspect Your House(i)\nHead Outside(h)");
                choice1 = ReadLine().ToLower();
                if (choice1.Equals("i")) {
                    WriteLine("Your house is a small cabin in the woods. You live alone and gather food from the forest everyday. The house is well built and you are glad to call it home.");
                } else if (!(choice1 == "h")){
                    WriteLine("INVALID ACTION");
                }
            }

            //Put what happens after you click h here!

            WriteLine("That's All For Now! Press Enter To Exit Program.");
            Read();

        }
    }
}
