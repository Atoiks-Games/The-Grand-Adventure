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
            string nameFirst = "";
            string nameLast = "";
            string nameCheck = "y";
            string race = "h";

            Random rnd = new Random();
            int strength = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + 3;
            int dexterity = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) +3;
            int constitution = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) +3;
            int intelligence = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) +3;
            int wisdom = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) +3;
            int charisma = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) +3;

            WriteLine("Your strength is: " + strength);
            WriteLine("Your dexterity is: " + dexterity);
            WriteLine("Your constitution is: " + constitution);
            WriteLine("Your intelligence is: " + intelligence);
            WriteLine("Your wisdom is: " + wisdom);
            WriteLine("Your charisma is: " + charisma);
              
        Namer:
            WriteLine("What is your first name adventurer? ");
            nameFirst = ReadLine();
            WriteLine("What is your last name adventurer? ");
            nameLast = ReadLine();
            WriteLine("Your name is: " + nameFirst + " " + nameLast + ". Is this correct? (y/n)");
            nameCheck = ReadLine();
            if (nameCheck.Equals("n")){
                goto Namer;
            };

         Race:
            WriteLine("What race do you wish to be? Write the first letter lowercase!");
            WriteLine("Dwarf: +2 Con, +1 Str, -1 Dex");
            WriteLine("Human: +2 Cha, +1 Str, -1 Wis");
            WriteLine("Elf: +2 Int, +1 Dex, -1 Con");
            WriteLine("Gnome: +2 Dex, +1 Cha, -1 Str");
            WriteLine("Infernal: +2 Wis, +1 Int, -1 Cha");
            WriteLine("Lizardfolk: +2 Str, +1 Con, -1 Cha");
            race = ReadLine();
            if (race.Equals("d")){
                constitution = constitution + 2;
                strength = strength + 1;
                dexterity = dexterity - 1;
                WriteLine("You are now a dwarf! Diggy Diggy Hole!");
            } else if (race.Equals("h")){
                charisma = charisma + 2;
                strength = strength + 1;
                wisdom = wisdom - 1;
                WriteLine("You are now a human! Yay!");
            } else if (race.Equals("e")){
                intelligence = intelligence + 2;
                dexterity = dexterity + 1;
                constitution = constitution - 1;
                WriteLine("You are now an elf! A very popular choice...");
            } else if (race.Equals("g")){
                dexterity = dexterity + 2;
                charisma = charisma + 1;
                strength = strength - 1;
                WriteLine("You are now a gnome! How cute!");
            } else if (race.Equals("i")){
                wisdom = wisdom + 2;
                intelligence = intelligence + 1;
                charisma = charisma - 1;
                WriteLine("You are now an infernal! Is it me or is it getting hot in here?");
            } else if (race.Equals("l")){
                strength = strength + 2;
                constitution = constitution + 1;
                charisma = charisma - 1;
                WriteLine("You are now a lizardfolk. Hisssssssss...");
            }else{
                WriteLine("Ye dun goofed!");
                goto Race;
            }

            WriteLine("Your new strength is: " + strength);
            WriteLine("Your new dexterity is: " + dexterity);
            WriteLine("Your new constitution is: " + constitution);
            WriteLine("Your new intelligence is: " + intelligence);
            WriteLine("Your new wisdom is: " + wisdom);
            WriteLine("Your new charisma is: " + charisma);
            Read();

        }
    }
}
