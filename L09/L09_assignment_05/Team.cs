using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_05
{
    class Team
    {
        //constuctor
        public Team(string team)
        {
            RetrievePlayers(team);
        }

        //methods
        private void RetrievePlayers(string team)
        {
            if (team == "Kalpa")
            {
                players.Add(new Player("Denis","Godla","L",30));
                players.Add(new Player("Niko", "Hovinen", "L", 32));
                players.Add(new Player("Santeri", "Lukka", "R", 3));
                players.Add(new Player("Mikael", "Seppälä", "L", 5));
                players.Add(new Player("Eetu", "Sopanen", "R", 9));
            }
            foreach (Player p in players)
            {
                Console.WriteLine(p.ToString());
            }
        }
        //properties and collection
        private string Name { get; set; }
        private string City { get; set; }
        private List<Player> players = new List<Player>();
    }
}
