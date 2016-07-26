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
            WriteLine("You wake up. It's morning. You can hear the birds chirping and the nearby river flowing. You get out of bed and look around the tiny cabin you live in.");
            WriteLine("As you begin to get dressed you remeber that your adventuring contractor said he would be sending you a new task today. It would be in a parcel at the end of the long and twisted road to your house.");
            string choice1 = "Sup...";
            while (choice1 != "h")          // a != b is shorthand of !(a == b)
            {
                WriteLine("You decide to:\nInspect Your House(i)\nHead Outside(h)");
                choice1 = ReadLine().ToLower();
                if (choice1 == "i")
                {
                    WriteLine("Your house is a small cabin in the woods. You live alone and gather food from the forest everyday. The house is well built and you are glad to call it home.");
                }
                else if (choice1 != "h")
                {
                    WriteLine("INVALID ACTION");
                }
            }

            //Put what happens after you click h here!
        }

    }
}
