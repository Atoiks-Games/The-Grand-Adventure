using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TheGrandAdventure
{
    class Party
    {
        private List<Player> players = new List<Player>();

        public Party()
        {

        }

        public void DisplayNames()
        {
            foreach (Player aPlayer in players)
            {
                Console.WriteLine(aPlayer.firstName + " " + aPlayer.lastName);
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
    }
}
