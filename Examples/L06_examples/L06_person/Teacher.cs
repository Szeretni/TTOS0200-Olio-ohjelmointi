using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_person
{
    class Teacher : Person
    {
        public string Room { get; set; }

        // default constructor
        public Teacher()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Teacher(string firstName, string lastName, string room)
            : base(firstName, lastName) //vie kantaluokan konstruktorille
        {
            Room = room;
        }

        // just one method what Teacher can do 
        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return "Teacher "; // + base.ToString() + " " + Room;
        }
    }
}