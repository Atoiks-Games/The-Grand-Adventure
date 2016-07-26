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
        private int STR = 0;
        public int strength
        {
            get
            {
                return STR;
            }
            set
            {
                STR = STR + value;
            }
        }
        private int DEX = 0;
        public int dexterity
        {
            get
            {
                return DEX;
            }
            set
            {
                DEX = DEX + value;
            }
        }
        private int CON = 0;
        public int constitution
        {
            get
            {
                return CON;
            }
            set
            {
                CON = CON + value;
            }
        }
        private int INT = 0;
        public int intelligence
        {
            get
            {
                return INT;
            }
            set
            {
                INT = INT + value;
            }
        }
        private int WIS = 0;
        public int wisdom
        {
            get
            {
                return WIS;
            }
            set
            {
                WIS = WIS + value;
            }
        }
        private int CHA = 0;
        public int charisma
        {
            get
            {
                return CHA;
            }
            set
            {
                CHA = CHA + value;
            }
        }

        private string firstName = "";
        public string fName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        private string lastName = "";
        public string lName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public enum CharacterRace
        {
            DWARF = 0, HUMAN, ELF, GNOME, INFERNAL, LIZARDFOLK
        }
        public enum CharacterClass
        {
            KNIGHT = 0, RANGER, MAGE, THIEF, CLERIC, BARBARIAN
        }
        public enum CharacterWeapon // TODO: Added weapons, will affect attack damage later on in game...
        {
            SWORD = 0, LONGSWORD, GREATSWORD, BOW, LONGBOW, CROSSBOW, STAFF, LONGSTAFF, BOSTAFF, DAGGER, THROWINGKNIFE, KUNAI, CROSS, IDOL, TOME, AXE, BATTLEAXE, WARHAMMER
        }
        private CharacterClass playerClass; // Using private modifier here
        public CharacterClass playClass
        {
            get
            {
                return playerClass;
            }
            set
            {
                playerClass = value;
            }
        }
        private CharacterRace playerRace;
        public CharacterRace playRace
        {
            get
            {
                return playerRace;
            }
            set
            {
                playerRace = value;
            }
        }
        private CharacterWeapon playerWeapon;
        public CharacterWeapon playWeapon
        {
            get
            {
                return playerWeapon;
            }
            set
            {
                playerWeapon = value;
            }
        }

        private int resistance = 0;
        public int ac
        {
            get
            {
                return resistance;
            }
            set
            {
                resistance = resistance + value;
            }
        }
        private int level = 1;
        public int lvl
        {
            get
            {
                return level;
            }
            set
            {
                level = level + value;
            }
        }
        private int health = 0;
        public int hp
        {
            get
            {
                return health;
            }
            set
            {
                health = Math.Min(health + value, maxHealth); // ensures player doesn't go over max health
            }
        }
        private int maxHealth = 0;
        public int maxHp
        {
            get
            {
                return maxHealth;
            }
            set
            {
                maxHealth = value;          // Consider taking account of when the new maxHp is smaller than
            }                               // the player's current hp.
        }
        private int damageModifier = 0;
        public int dmgMod
        {
            get
            {
                return damageModifier;
            }
            set
            {
                damageModifier = value + level;
            }
        }

        public Player(int playerNumber)
        {
            WriteLine("Welcome player {0}!", playerNumber);
        }
        public void GenerateScores(int fudgeFactor)
        {
            Random rnd = new Random();
            strength = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            dexterity = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            constitution = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            intelligence = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            wisdom = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            charisma = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6) + fudgeFactor;
            DisplayScores();
        }
        public void DisplayScores()
        {
            WriteLine("Your strength is: " + strength);
            WriteLine("Your dexterity is: " + dexterity);
            WriteLine("Your constitution is: " + constitution);
            WriteLine("Your intelligence is: " + intelligence);
            WriteLine("Your wisdom is: " + wisdom);
            WriteLine("Your charisma is: " + charisma);
        }
        public void DetermineRace()
        {
            while (true)
            {
                string race = ReadLine().ToLower().Trim();
                switch (race)
                {
                    case "d":
                        constitution = 2;
                        strength = 1;
                        dexterity = -1;
                        playerRace = CharacterRace.DWARF;
                        WriteLine("You are now a dwarf! Diggy Diggy Hole!");
                        goto end;       // I am afraid the gotos are back
                    case "h":
                        charisma = 2;
                        strength = 1;
                        wisdom = -1;
                        playerRace = CharacterRace.HUMAN;
                        WriteLine("You are now a human! Yay!");
                        goto end;
                    case "e":
                        intelligence = 2;
                        dexterity = 1;
                        constitution = -1;
                        playerRace = CharacterRace.ELF;
                        WriteLine("You are now an elf! A very popular choice...");
                        goto end;
                    case "g":
                        dexterity = 2;
                        charisma = 1;
                        strength = -1;
                        playerRace = CharacterRace.GNOME;
                        WriteLine("You are now a gnome! How cute!");
                        goto end;
                    case "i":
                        wisdom = 2;
                        intelligence = 1;
                        charisma = -1;
                        playerRace = CharacterRace.INFERNAL;
                        WriteLine("You are now an infernal! Is it me or is it getting hot in here?");
                        goto end;
                    case "l":
                        strength = 2;
                        constitution = 1;
                        charisma = -1;
                        playerRace = CharacterRace.LIZARDFOLK;
                        WriteLine("You are now a lizardfolk. Hisssssssss...");
                        goto end;
                    default:
                        WriteLine("Ye dun goofed! That is not a valid choice!");
                        break;
                }
            }
        end: return;
        }
        public void DetermineClass()
        {
            while (true)
            {
                string adventuringClass = ReadLine().ToLower().Trim();
                switch (adventuringClass)
                {
                    case "k":
                        constitution = 2;
                        strength = 1;
                        playerClass = CharacterClass.KNIGHT;
                        playerWeapon = CharacterWeapon.SWORD;
                        WriteLine("You are now a knight! Huzzah!");
                        ac = 15;
                        dmgMod = strength + lvl;
                        maxHp = lvl * constitution;
                        hp = maxHealth;
                        goto end;
                    case "r":
                        wisdom = 2;
                        dexterity = 1;
                        playerClass = CharacterClass.RANGER;
                        playerWeapon = CharacterWeapon.BOW;
                        WriteLine("You are now a ranger! One shot. One kill.");
                        ac = 10 + (dexterity - 10);
                        dmgMod = dexterity + lvl;
                        maxHp = lvl * constitution;
                        hp = maxHealth;
                        goto end;
                    case "m":
                        intelligence = 2;
                        wisdom = 1;
                        playerClass = CharacterClass.MAGE;
                        playerWeapon = CharacterWeapon.STAFF;
                        WriteLine("You are now a mage! Fireball!");
                        ac = 10 + (dexterity - 10);
                        dmgMod = intelligence + lvl;
                        maxHp = lvl * constitution;
                        hp = maxHealth;
                        goto end;
                    case "t":
                        dexterity = 2;
                        charisma = 1;
                        playerClass = CharacterClass.THIEF;
                        playerWeapon = CharacterWeapon.DAGGER;
                        WriteLine("You are now a thief! Time to loot the bodies!");
                        ac = 10 + (dexterity - 10) + lvl;
                        dmgMod = strength + lvl;
                        maxHp = lvl * constitution;
                        hp = maxHealth;
                        goto end;
                    case "c":
                        charisma = 2;
                        intelligence = 1;
                        playerClass = CharacterClass.CLERIC;
                        playerWeapon = CharacterWeapon.CROSS;
                        WriteLine("You are now a cleric! Channel the gods' wrath!");
                        ac = 12 + lvl;
                        dmgMod = charisma + lvl;
                        maxHp = lvl * constitution;
                        hp = maxHealth;
                        goto end;
                    case "b":
                        strength = 2;
                        constitution = 1;
                        playerClass = CharacterClass.BARBARIAN;
                        playerWeapon = CharacterWeapon.AXE;
                        WriteLine("You are now a barbarian! ROOOAAR!!!");
                        ac = 10 + (dexterity - 10) + lvl;
                        dmgMod = strength + lvl;
                        maxHp = lvl * constitution;
                        hp = maxHealth;
                        goto end;
                    default:
                        WriteLine("Ye dun goofed! That is not a valid choice!");
                        break;
                }
            }
        end: return;
        }
    }
}
