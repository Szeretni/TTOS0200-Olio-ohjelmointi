using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Hannu";
            person.LastName = "Oksman";
            person.Address = "Jyvaskyla";
            person.Age = 33;
            person.PhoneNumber = "123-456789";
            Console.WriteLine(person.ToString());

            Teacher jani = new Teacher("Jani", "Immonen", "Unavailable");
            jani.Address = "Tampere";
            jani.Age = 50;
            jani.PhoneNumber = "987-654321";
            Console.WriteLine(jani.ToString());

            Student pekka = new Student("Pekka","Jappinen","L123345");
            pekka.Address = "Lutakko";
            pekka.Age = 20;
            pekka.PhoneNumber = "456-132789";
            Console.WriteLine(pekka.ToString());

            /*
            Person somebody = new Student("test", "testing","studID");
            //somebody.studentID = "123"; doesnt work, object is Person type
            Console.WriteLine(somebody.ToString());
            */

            
            List<Person> people = new List<Person>();
            for ( int i = 0; i < 20; i++)
            {
                if (i<5)
                {
                    people.Add(new Person());
                }
                else if (i<12)
                {
                    people.Add(new Teacher());
                }
                else
                {
                    people.Add(new Student());
                }
            }


            
            foreach (Person personInPeople in people)
            {
                Console.WriteLine(personInPeople.ToString());
            }
            

            /*
            Person[] people = new Person[20];

            for (int i = 0; i<20; i++)
            {
                if (i < 5)
                {
                    people[i] = new Person();
                }
                else if (i < 12)
                {
                    people[i] = new Teacher();
                }
                else
                {
                    people[i] = new Student();
                }
            }
            
            for (int i = 0; 1 < 20; i++)
            {
                Person p = people.ElementAt(i);
                Console.WriteLine(p.ToString());
            }
            */
        }
    }
}
