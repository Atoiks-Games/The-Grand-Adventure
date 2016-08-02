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
            Party party = new TheGrandAdventure.Party();
            bool c = false;
            WriteLine("Welcome To:\n\n _The Grand Adventure_ \n\n Let's begin by assembling your party. How many adventurers do you want in your party?");
            bool failure = true;
            while (failure == true)
            {
                try
                {
                    party.playerNumber = Convert.ToInt32(ReadLine());
                    failure = false;
                }
                catch
                {
                    WriteLine("Please enter a number...");
                }
            }
            WriteLine("Great! Let's create the members of your party!");




            while (party.count <= (party.playerNumber - 1))
            {
                Player player = new TheGrandAdventure.Player();
                while (c == true)
                {
                    bool a = true;
                    while (a == true)
                    {
                        WriteLine("What is this party member's first name?");
                        string input1 = ReadLine();
                        if (input1.Trim().Equals(""))
                        {
                            WriteLine("Nice try. Actually write some characters this time please.");
                        }
                        else
                        {
                            player.firstName = input1.Trim();
                            a = false;
                        }
                    }
                    bool b = true;
                    while (b == true)
                    {
                        WriteLine("What is this party member's last name?");
                        string input2 = ReadLine();
                        if (input2.Trim().Equals(""))
                        {
                            WriteLine("Nice try. Actually write some characters this time please.");
                        }
                        else
                        {
                            player.lastName = input2.Trim();
                            b = false;
                        }
                    }
                    WriteLine("The character's name is {0} {1}. Is that correct? (Type y for yes. Type anything else for no.)", player.firstName, player.lastName);
                    if (ReadLine().ToLower().Trim().Equals("y"))
                    {
                        c = false;
                    }
                }
                WriteLine("Is this party member a male? (Type y for yes. Type anything else for no.)");
                if (ReadLine().Trim().ToLower() != "y")
                {
                    player.male = false;
                }
                player.Pronouns();
                player.GenerateScores(1);

                WriteLine("What race do you wish this character to be? Write the first letter!");
                WriteLine("Dwarf: +2 Con, +1 Str, -1 Dex");
                WriteLine("Human: +2 Cha, +1 Str, -1 Wis");
                WriteLine("Elf: +2 Int, +1 Dex, -1 Con");
                WriteLine("Gnome: +2 Dex, +1 Cha, -1 Str");
                WriteLine("Infernal: +2 Wis, +1 Int, -1 Cha");
                WriteLine("Lizardfolk: +2 Str, +1 Con, -1 Cha");
                player.DetermineRace();
                player.DisplayScores();
                WriteLine("Now you must choose your adventuring class! Again write the first letter!");
                WriteLine("Knight");
                WriteLine("Ranger");
                WriteLine("Mage");
                WriteLine("Theif");
                WriteLine("Cleric");
                WriteLine("Barbarian");
                player.DetermineClass();
                player.DisplayScores();
                WriteLine("Congrats! This adventurer is ready for your adventure! {2} name is {0} {1}.", player.firstName, player.lastName, player.His);
                WriteLine("{0} race is: " + player.characterRace, player.His);
                WriteLine("{0} class is: " + player.characterClass, player.His);
                WriteLine("Press enter to continue...");
                ReadLine();
                WriteLine(player.His + " weapon is the: " + player.characterWeapon);
                WriteLine(player.His + " health is: " + player.health);
                WriteLine(player.His + " damage resistance is: " + player.resistance);
                WriteLine(player.His + " damage modifier is: " + player.damageModifier);

                party.AddPlayer(player);

                if (party.count != (party.playerNumber - 1))
                {
                    WriteLine("Let's move onto the next member of your party!");
                }
                party.count++;
            }

            WriteLine("You are now ready to begin your adventure!");
            WriteLine("Your adventurers are:");
            party.DisplayNames();
            ReadKey();

            Chapter1 Playthrough = new TheGrandAdventure.Chapter1();
            Playthrough.Play();

            WriteLine("The End");
            Read();
        }
    }
}
