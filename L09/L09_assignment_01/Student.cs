using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_01
{
    class Student
    {
        //constructor
        public Student (string AsioID, string FirstName, string LastName,string Group)
        {
            this.AsioID = AsioID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Group = Group;
            //Console.WriteLine("New student with AsioID {0} created.", AsioID);
        }

        //destructor
        ~Student()
        {
            //Console.WriteLine("Student with AsioID {0} is removed.", AsioID);
        }

        //methods
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + AsioID + " " + Group;
        }

        //properties
        public string AsioID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        
        /* never used
        private string firstName;
        private string lastName;
        private string group;
        private string asioID;
        */
    }
}
