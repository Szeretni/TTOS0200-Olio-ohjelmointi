using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_03
{
    class Card
    {
        //constructor
        public Card(int Country, int Rank)
        {
            this.Country = Country;
            this.Rank = Rank;
        }

        //properties
        public int Country { get; set; }
        public int Rank { get; set; }
        private string diamond = "Diamond";
        private string club = "Club";
        private string spade = "Spade";
        private string heart = "Heart";

        //methods
        public override string ToString()
        {
            string country;
            if (Country == 1)
            {
                country = diamond;
            }
            else if (Country == 2)
            {
                country = club;
            }
            else if (Country == 3)
            {
                country = spade;
            }
            else
            {
                country = heart;
            }
            return country + "#" + Rank;

            //not so good
            /*
            if (Country == 1)
            {
                return diamond + "#" + Rank;
            }
            else if (Country == 2)
            {
                return club + "#" + Rank;
            }
            else if (Country == 3)
            {
                return spade + "#" + Rank;
            }
            else
            {
                return heart + "#" + Rank;
            }
            */
        }
    }
}
