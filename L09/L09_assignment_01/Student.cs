using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_01
{
    class Student
    {
        //constructors
        public Student (string AsioID)
        {
            this.AsioID = AsioID;
            Console.WriteLine("New student with AsioID {0} created.", AsioID);
        }

        public Student(string FirstName,string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            //leftover: Console.WriteLine("New student with AsioID {0} created.", AsioID);
        }

        //destructor
        ~Student()
        {
            Console.WriteLine("Student with AsioID {0} is removed.", AsioID);
        }

        //methods

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
