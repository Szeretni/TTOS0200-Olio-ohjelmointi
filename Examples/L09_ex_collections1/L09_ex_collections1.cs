using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_ex_collections1
{
    class L09_ex_collections1
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            persons.Add(new Person { Firstname = "Teppo", Lastname = "Teppo", SocialSecurityNumber = "789" });
            persons.Add(new Person { Firstname = "Jani", Lastname = "Immonen", SocialSecurityNumber = "13245687" });
            persons.Add(new Person { Firstname = "Matti", Lastname = "Matti", SocialSecurityNumber = "123" });
            

            Console.WriteLine(persons.ElementAt(0).ToString());

            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
                if (person == persons.Last())
                {
                    Console.WriteLine("LAST!");
                }
            }

            //requires IComparable
            persons.Sort();

            //persons.Sort((x,y) => x.Lastname.CompareTo(y.Lastname));
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
        /*
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Anna",
                "Pekka",
                "Kimmo",
                "Daavetti"
            };

            //$ {}
            names.ForEach(name => Console.WriteLine($"Hello {name}"));
            //names.ForEach(name => Console.WriteLine("Hello {0}", name));

            names.ForEach(ShowInConsole);
            

        }
        private static void ShowInConsole(string txt)
        {
            Console.WriteLine(txt);
        }
        */
    }
}
