using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_ex_dict
{
    class L09_ex_dict
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            Person person1 = new Person { Firstname = "Kirsti", Lastname = "asfd", SocialSecurityNumber = "654654" };
            Person person2 = new Person { Firstname = "Paavo", Lastname = "fadga", SocialSecurityNumber = "31749" };
            Person person3 = new Person { Firstname = "Pekka", Lastname = "fjhgkgfhkf", SocialSecurityNumber = "9876543" };

            persons.Add(person1.SocialSecurityNumber, person1);
            persons.Add(person2.SocialSecurityNumber, person2);
            persons.Add(person3.SocialSecurityNumber, person3);

            string ssn = "98765431";
            Person found;
            if (persons.TryGetValue(ssn, out found))
            {
                Console.WriteLine("Person wisn SSN {0} found: {1}", ssn, found.ToString());
            }
            else
            {
                Console.WriteLine("Person wisn SSN {0} NOT FOUND!", ssn);
            }
            /*
            if (persons.ContainsKey(key))
            {
                Console.WriteLine("Person wisn SSN {0} found: {1}", key, persons[key].ToString());
            }
            */

            foreach (string key in persons.Keys)
            {
                Console.WriteLine(key);
            }

            foreach(Person person in persons.Values)
            {
                Console.WriteLine(person.ToString());
            }
            
            foreach (KeyValuePair<string, Person> kvp in persons)
            {
                Console.WriteLine("{0} : {1}", kvp.Key,kvp.Value);
            }

            if (persons.ContainsKey(ssn))
            {
                persons.Remove(ssn);
            }
        }
    }
}
