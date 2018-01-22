using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_assignment06
{
    class L03_assignment06
    {
        static void Main(string[] args)
        {
            ClassTeacher teacher1 = new ClassTeacher();
            teacher1.Salary = 3000;
            teacher1.Vacancy = "Full-time";
            teacher1.Qualifications = "PhD";
            teacher1.Course = "Programming";
            teacher1.Name = "Teachy Teacher";

            Console.WriteLine("Teacher's name: " + teacher1.Name);
            Console.WriteLine("Teacher's salary: " + teacher1.Salary);
            Console.WriteLine("Teacher's courses: " + teacher1.Course);
            Console.WriteLine("Teacher's qualifications: " + teacher1.Qualifications);
        }
    }
}