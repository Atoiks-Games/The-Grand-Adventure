using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TheGrandAdventure
{
    class Chapter1
    {
        public Chapter1()
        {
            WriteLine("\n\n _CHAPTER 1: The Missing Merchant_ \n\n");
        }
        public void Play()
        {
            WriteLine("Your party wakes up in their rooms of the inn. It's morning. They can hear the birds chirping and the nearby river flowing. They get out of bed and look around the tiny room they slept in.");
            WriteLine("As they begin to get dressed they remeber that their adventuring contractor said he would be sending them a new task today. It would be in a parcel at the end of the long and twisted road to the dropzone.");
            string choice1 = "Sup...";
            while (!(choice1 == "m"))
            {
                WriteLine("What should your party do?:\nInspect Their Rooms(i)\nMeet up in The Tavern Below Their Rooms(m)");
                choice1 = ReadLine().ToLower();
                if (choice1.Equals("i"))
                {
                    WriteLine("Their rooms are small and dusty. Each character's adventuring pack lays on the small bed. The window is opaque with dust and grime. It isn't pretty, but it's cheap.");
                }
                else if (!(choice1 == "m"))
                {
                    WriteLine("INVALID ACTION");
                }
            }

            //Put what happens after you click h here!
        }

    }
}
