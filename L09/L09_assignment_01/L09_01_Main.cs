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

        //AsioID generation, used in AddStudent-method
        static int AsioIDint = 0;
        static char AsioIDstr = 'Z';
        
        //methods
        static string GenerateAsioID(ref int AsioIDint, ref char AsioIDstr)
        {
            string AsioID = AsioIDstr.ToString();
            for (int i = 0; i < 4; i++)
            {
                AsioID += AsioIDint.ToString();
            }
            return AsioID;
        }

        static void AddStudent(string firstname, string lastname, string group)
        {
            string AsioID = GenerateAsioID(ref AsioIDint, ref AsioIDstr);
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
                student.Add(new Student(AsioID,firstname,lastname,group));
                //updates for AsioID-generation
                if (AsioIDint == 10)
                {
                    AsioIDint = 1;
                }
                else
                {
                    AsioIDint++;
                }
                if (AsioIDstr == 'Z')
                {
                    AsioIDstr = 'A';
                }
                else
                {
                    AsioIDstr++;
                }
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
            //adding students
            AddStudent("Masa","Niemi","");
            AddStudent("Allan", "Aalto", "");
            AddStudent("Hanna", "Husso", "");
            AddStudent("Teppo", "Testaaja", "TTV17S1");

            //first and last
            Console.WriteLine("The First Student in the MiniASIO is:\n{0}", student.First().ToString());
            Console.WriteLine("The Last Student in the MiniASIO is:\n{0}", student.Last().ToString());
            Console.WriteLine();
            
            //all students
            foreach (Student s in student)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();

            //alphabetical order


            /*used to validate project
            AddStudent("asdf123");
            ModifyStudent("asdf123");
            RemoveStudent("asdf123");
            Console.WriteLine(AsioIDint); 
            Console.WriteLine(AsioIDstr);
            */
        }
    }
}