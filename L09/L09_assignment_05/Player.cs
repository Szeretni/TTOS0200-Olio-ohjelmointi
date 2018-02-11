using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_05
{
    class Player
    {
        //constructor
        public Player(string Firstname, string Lastname,string Handness,int Number)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Handness = Handness;
            this.Number = Number;
        }

        //methods
        public override string ToString()
        {
            return Number + ", " + Firstname + " " + Lastname + ", " + Handness + "."; 
        }

        //properties
        private string Firstname { get; set; }
        private string Lastname { get; set; }
        private string Handness { get; set; }
        private int Number { get; set; }
    }
}
