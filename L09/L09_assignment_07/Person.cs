using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_07
{
    class Person
    {
        //constructor
        public Person(Random random)
        {
            //generating first name
            for (int i = 0; i<4;i++)
            {
                int rand = random.Next(0, 26);
                char c = 'A';
                for (int j = 0; j < rand;j++)
                {
                    c++;
                }
                Firstname += c;
            }
            //generating last name
            for (int i = 0; i < 10; i++)
            {
                int rand = random.Next(0, 26);
                char c = 'A';
                for (int j = 0; j < rand; j++)
                {
                    c++;
                }
                Lastname += c;
            }
        }

        //methods
        public override string ToString()
        {
            return "Found person with " + Firstname + " firstname : " + Firstname + " " + Lastname;
        }

        //properties
        private string Firstname { get; set; }
        private string Lastname { get; set; }
    }
}