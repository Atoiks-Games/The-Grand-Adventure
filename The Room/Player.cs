using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TheGrandAdventure
{
    class Player
    {

        public bool male = true;
        public string his = "his";
        public string His = "His";
        public string he = "he";
        public string He = "He";



        public int STR = 0;
        public int DEX = 0;
        public int CON = 0;
        public int INT = 0;
        public int WIS = 0;
        public int CHA = 0;

        public string firstName = "k";
        public string lastName = "k";

        public enum CharacterRace
        {
            DWARF, HUMAN, ELF, GNOME, INFERNAL, LIZARDFOLK
        }
        public enum CharacterClass
        {
            KNIGHT, RANGER, MAGE, THIEF, CLERIC, BARBARIAN
        }
        public enum CharacterWeapon
        {
            SWORD, LONGSWORD, GREATSWORD, BOW, LONGBOW, CROSSBOW, STAFF, LONGSTAFF, BOSTAFF, DAGGER, THROWINGKNIFE, KUNAI, CROSS, IDOL, TOME, AXE, BATTLEAXE, WARHAMMER
        }
        public CharacterRace playRace;
        public CharacterClass playClass;
        public CharacterWeapon playWeapon;
        public string characterRace = "";
        public string characterClass = "";
        public string characterWeapon = "";

        public int resistance = 0;

        public int level = 1;

        public int health = 0;
        public int maxHealth = 0;
        public int damageModifier = 0;

        public Player()
        {

        }
        public void Pronouns()
        {
            if (male == false)
            {
                his = "her";
                His = "Her";
                he = "she";
                He = "She";
            }
        }

        public void GenerateScores(int fudgeFactor)
        {
            Random rnd = new Random();
            STR = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            DEX = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            CON = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            INT = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            WIS = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            CHA = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            DisplayScores();
        }
        public void DisplayScores()
        {
            WriteLine(firstName + " " + lastName + "'s strength is: " + STR);
            WriteLine(firstName + " " + lastName + "'s dexterity is: " + DEX);
            WriteLine(firstName + " " + lastName + "'s constitution is: " + CON);
            WriteLine(firstName + " " + lastName + "'s intelligence is: " + INT);
            WriteLine(firstName + " " + lastName + "'s wisdom is: " + WIS);
            WriteLine(firstName + " " + lastName + "'s charisma is: " + CHA);
        }
        public void DetermineRace()
        {
            bool a = true;
            while (a == true)
            {
                string race = ReadLine().ToLower().Trim();
                switch (race)
                {
                    case "d":
                        CON = CON + 2;
                        STR = STR + 1;
                        DEX = DEX - 1;
                        playRace = CharacterRace.DWARF;
                        characterRace = Convert.ToString(playRace);
                        WriteLine("You are now a dwarf! Diggy Diggy Hole!");
                        a = false;
                        break;
                    case "h":
                        CHA = CHA + 2;
                        STR = STR + 1;
                        WIS = WIS - 1;
                        playRace = CharacterRace.HUMAN;
                        characterRace = Convert.ToString(playRace);
                        WriteLine("You are now a human! Yay!");
                        a = false;
                        break;
                    case "e":
                        INT = INT + 2;
                        DEX = DEX + 1;
                        CON = CON - 1;
                        playRace = CharacterRace.ELF;
                        characterRace = Convert.ToString(playRace);
                        WriteLine("You are now an elf! A very popular choice...");
                        a = false;
                        break;
                    case "g":
                        DEX = DEX + 2;
                        CHA = CHA + 1;
                        STR = STR - 1;
                        playRace = CharacterRace.GNOME;
                        characterRace = Convert.ToString(playRace);
                        WriteLine("You are now a gnome! How cute!");
                        a = false;
                        break;
                    case "i":
                        WIS = WIS + 2;
                        INT = INT + 1;
                        CHA = CHA - 1;
                        playRace = CharacterRace.INFERNAL;
                        characterRace = Convert.ToString(playRace);
                        WriteLine("You are now an infernal! Is it me or is it getting hot in here?");
                        a = false;
                        break;
                    case "l":
                        STR = STR + 2;
                        CON = CON + 1;
                        CHA = CHA - 1;
                        playRace = CharacterRace.LIZARDFOLK;
                        characterRace = Convert.ToString(playRace);
                        WriteLine("You are now a lizardfolk. Hisssssssss...");
                        a = false;
                        break;
                    default:
                        WriteLine("Ye dun goofed! That is not a valid choice!");
                        break;
                }
            }
        }
        public void DetermineClass()
        {
            bool a = true;
            while (a == true)
            {
                string adventuringClass = ReadLine().ToLower().Trim();
                switch (adventuringClass)
                {
                    case "k":
                        CON = CON + 2;
                        STR = STR + 1;
                        playClass = CharacterClass.KNIGHT;
                        characterClass = Convert.ToString(playClass);
                        playWeapon = CharacterWeapon.SWORD;
                        characterWeapon = Convert.ToString(playWeapon);
                        WriteLine("You are now a knight! Huzzah!");
                        resistance = 15;
                        damageModifier = STR + level;
                        maxHealth = level * CON;
                        health = maxHealth;
                        a = false;
                        break;
                    case "r":
                        WIS = WIS + 2;
                        DEX = DEX + 1;
                        playClass = CharacterClass.RANGER;
                        characterClass = Convert.ToString(playClass);
                        playWeapon = CharacterWeapon.BOW;
                        characterWeapon = Convert.ToString(playWeapon);
                        WriteLine("You are now a ranger! One shot. One kill.");
                        resistance = 10 + (DEX - 10);
                        damageModifier = DEX + level;
                        maxHealth = level * CON;
                        health = maxHealth;
                        a = false;
                        break;
                    case "m":
                        INT = INT + 2;
                        WIS = WIS + 1;
                        playClass = CharacterClass.MAGE;
                        characterClass = Convert.ToString(playClass);
                        playWeapon = CharacterWeapon.STAFF;
                        characterWeapon = Convert.ToString(playWeapon);
                        WriteLine("You are now a mage! Fireball!");
                        resistance = 10 + (DEX - 10);
                        damageModifier = INT + level;
                        maxHealth = level * CON;
                        health = maxHealth;
                        a = false;
                        break;
                    case "t":
                        DEX = DEX + 2;
                        CHA = CHA + 1;
                        playClass = CharacterClass.THIEF;
                        characterClass = Convert.ToString(playClass);
                        playWeapon = CharacterWeapon.DAGGER;
                        characterWeapon = Convert.ToString(playWeapon);
                        WriteLine("You are now a thief! Time to loot the bodies!");
                        resistance = 10 + (DEX - 10) + level;
                        damageModifier = STR + level;
                        maxHealth = level * CON;
                        health = maxHealth;
                        a = false;
                        break;
                    case "c":
                        CHA = CHA + 2;
                        INT = INT + 1;
                        playClass = CharacterClass.CLERIC;
                        characterClass = Convert.ToString(playClass);
                        playWeapon = CharacterWeapon.CROSS;
                        characterWeapon = Convert.ToString(playWeapon);
                        WriteLine("You are now a cleric! Channel the gods' wrath!");
                        resistance = 10 + level;
                        damageModifier = CHA + level;
                        maxHealth = level * CON;
                        health = maxHealth;
                        a = false;
                        break;
                    case "b":
                        STR = STR + 2;
                        CON = CON + 1;
                        playClass = CharacterClass.BARBARIAN;
                        characterClass = Convert.ToString(playClass);
                        playWeapon = CharacterWeapon.AXE;
                        characterWeapon = Convert.ToString(playWeapon);
                        WriteLine("You are now a barbarian! ROOOFAAR!!!");
                        resistance = 10 + (DEX - 10) + level;
                        damageModifier = STR + level;
                        maxHealth = level * CON;
                        health = maxHealth;
                        a = false;
                        break;
                    default:
                        WriteLine("Ye dun goofed! That is not a valid choice!");
                        break;
                }
            }
        }
    }
}
