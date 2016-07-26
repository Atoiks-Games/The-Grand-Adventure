using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TheGrandAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome To:\n\n _The Grand Adventure_ \n\n Let's begin by determining your character's ability rankings and figuring out your name!");
            Player Player1 = new TheGrandAdventure.Player(1); //No need to be static!
            Player1.GenerateScores(1); //1 is fudgeFactor...
            bool c = true;
            while (c)                       // Sometimes, == just works. You should be .Equals when comparing Objects
            {
                bool a = true;              // For Flag / Toggle values, use boolean
                while (a)
                {
                    WriteLine("What is your first name?");
                    string input1 = ReadLine().Trim();  // Trim early so its called once.
                    if (input1 == "")
                    {
                        WriteLine("Nice try. Actually write some characters this time please.");
                    }
                    else
                    {
                        Player1.fName = input1;
                        a = false;
                    }
                }
                bool b = true;              // Couldn't you just use `a`` here? (Or no variables, just break?)
                while (b)
                {
                    WriteLine("What is your last name?");
                    string input2 = ReadLine().Trim();
                    if (input2.Trim() == "")
                    {
                        WriteLine("Nice try. Actually write some characters this time please.");
                    }
                    else
                    {
                        Player1.lName = input2;
                        b = false;
                    }
                }
                WriteLine("Your name is {0} {1}. Is that correct? (Type y for yes. Type anything else for no.)", Player1.fName, Player1.lName);
                if (ReadLine().ToLower().Trim() == "y")
                {
                    c = false;
                }
            }
            WriteLine("What race do you wish to be? Write the first letter!");
            WriteLine("Dwarf: +2 Con, +1 Str, -1 Dex");
            WriteLine("Human: +2 Cha, +1 Str, -1 Wis");
            WriteLine("Elf: +2 Int, +1 Dex, -1 Con");
            WriteLine("Gnome: +2 Dex, +1 Cha, -1 Str");
            WriteLine("Infernal: +2 Wis, +1 Int, -1 Cha");
            WriteLine("Lizardfolk: +2 Str, +1 Con, -1 Cha");
            Player1.DetermineRace();
            Player1.DisplayScores();
            WriteLine("Now you must choose your adventuring class! Again write the first letter!");
            WriteLine("Knight");
            WriteLine("Ranger");
            WriteLine("Mage");
            WriteLine("Theif");
            WriteLine("Cleric");
            WriteLine("Barbarian");
            Player1.DetermineClass();
            Player1.DisplayScores();
            WriteLine("Congrats! You are ready for your adventure! Your name is {0} {1}.", Player1.fName, Player1.lName);
            WriteLine("Your race is: " + Player1.playRace);
            WriteLine("Your class is: " + Player1.playClass);
            WriteLine("Press enter to continue...");
            ReadLine();
            WriteLine("Your weapon is the: " + Player1.playWeapon);
            WriteLine("Your health is: " + Player1.hp);
            WriteLine("Your damage resistance is: " + Player1.ac);
            WriteLine("Your damage modifier is: " + Player1.dmgMod);
            WriteLine("You are ready to begin your adventure!");

            Chapter1 playthrough = new Chapter1();
            playthrough.Play();

            WriteLine("The End");
            Read();
        }
    }
}
