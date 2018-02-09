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
        public Student (string AsioID)
        {
            this.AsioID = AsioID;
        }

        //methods
        /*
        public void RemoveStudent(string AsioID)
        {
            foreach (Student s in student)
            {
                if (s.AsioID == AsioID)
                {
                    student.Remove(s);
                }
            }
        }
        */

        public void ModifyStudent(string AsioID)
        {
            Console.WriteLine("1) Modify First Name");
            Console.WriteLine("2) Modify Last Name");
            Console.WriteLine("3) Modify Group");
            int selection;
            bool r = int.TryParse(Console.ReadLine(),out selection);
            switch (selection)
            {
                case 1:
                    Console.Write("Type new first name: ");
                    break;
            }

        }

        //autos
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Group { get; set; }
        private string AsioID { get; set; }

        //properties
        private string firstName;
        private string lastName;
        private string group;
        private string asioID;
    }
}
