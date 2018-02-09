using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_01
{
    class L09_01_Main
    {
        //collection
        static List<Student> student = new List<Student>();

        //add student
        static void AddStudent(string AsioID)
        {
            student.Add(new Student(AsioID));
        }

        static void Main(string[] args)
        {
            AddStudent("1");
        }
    }
}