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

        //methods
        static void AddStudent(string AsioID)
        {
            //checks list if given id already exists
            bool checkExistence = false;
            foreach (Student s in student)
            {
                if (s.AsioID == AsioID)
                {
                    Console.WriteLine("Student with given AsioID exists, give a new ID.");
                    checkExistence = true;
                }   
            }
            //if new, create student
            if (!checkExistence)
            {
                student.Add(new Student(AsioID));
            }
        }
        
        static void RemoveStudent(string AsioID)
        {
            foreach (Student s in student)
            {
                if (s.AsioID == AsioID)
                {
                    student.Remove(s);
                    //break needed to avoid "System.InvalidOperationException: Kokoelmaa muokattiin. Luettelointitoimintoa ei voi suorittaa."
                    break;
                    //works also
                    //student.Remove(new Student(AsioID));
                }
            }
        }

        static void ModifyStudent(string AsioID)
        {
            foreach (Student s in student)
            {
                if (s.AsioID == AsioID)
                {
                    bool r = false;
                    int selection;
                    do
                    {
                        Console.WriteLine("1) Modify First Name");
                        Console.WriteLine("2) Modify Last Name");
                        Console.WriteLine("3) Modify Group");
                        r = int.TryParse(Console.ReadLine(), out selection);
                    } while (!r);

                    switch (selection)
                    {
                        default:
                            Console.WriteLine("Invalid input {0}", selection);
                            break;
                        case 1:
                            Console.Write("Type a new first name: ");
                            s.FirstName = Console.ReadLine();
                            Console.WriteLine("New first name is now {0}",s.FirstName);
                            break;
                        case 2:
                            Console.Write("Type a new last name: ");
                            s.LastName = Console.ReadLine();
                            Console.WriteLine("New last name is now {0}",s.LastName);
                            break;
                        case 3:
                            Console.Write("Type a new group: ");
                            s.Group = Console.ReadLine();
                            Console.WriteLine("New group is now {0}",s.Group);
                            break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //placeholder
            foreach (Student s in student)
            {
                Console.WriteLine("Student's AsioID: {0}", s.AsioID);
            }

            AddStudent("asdf123");
            ModifyStudent("asdf123");
            RemoveStudent("asdf123");
        }
    }
}