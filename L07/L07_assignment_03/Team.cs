using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_03
{
    class Team
    {
        public Team(int initPlayers)
        {
            Console.WriteLine("Team created.");
            for (int i = 0; i<initPlayers;i++)
            {
                players.Add(new Player(i.ToString()));
            }
        }
        public List<Player> players = new List<Player>();
        private string Name { get; set; }
        private string City { get; set; }
    }
}