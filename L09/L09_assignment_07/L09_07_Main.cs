/*
Toteuta C#:lla ohjelma, jossa List-tietorakenteeseen lisätään satunnaisesti luotuja Person-luokan oliota 10.000 kappaletta. 
Person-luokan olion etunimessä on käytettävä satunnaisesti kirjaimia väliltä A-Z ja etunimen pituus on 4 merkkiä. 
Sukunimi samoin, mutta pituus on 10 merkkiä.

Ohjelman tulee tulostaa henkilöiden lisäykseen kulunut aika millisekunteina. 
Etsi tämän jälkeen tietorakenteesta 1000 satunnaista henkilöä rekisteristä etunimen perusteella. 
Tulosta löydettyjen henkilöiden tiedot sekä hakuun yhteensä kulunut aika millisekuntteina. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_07
{
    class L09_07_Main
    {
        static void Main(string[] args)
        {
            //properties
            int size = 10000;

            //collection
            List<Person> list = new List<Person>();

            //random
            Random random = new Random();

            //generating persons
            DateTime Init = DateTime.Now;
            for (int i = 0;i<size;i++)
            {
                list.Add(new Person(random));
            }
            DateTime Stop = DateTime.Now;
            int genTimeL = Stop.Millisecond - Init.Millisecond;

            //printing random 1000 persons
            Init = DateTime.Now;
            for (int i = 0;i<size*0.1;i++)
            {
                int rand = random.Next(0, size);
                Console.WriteLine(list.ElementAt(rand).ToString());
            }
            Stop = DateTime.Now;
            int priTimeL = Stop.Millisecond - Init.Millisecond;
            
            //dict
            Dictionary<string, Person> dictionary = new Dictionary<string, Person>();

            //generating persons
            Init = DateTime.Now;
            for (int i = 0; i < size; i++)
            {
                bool success;
                do
                {
                    success = true;
                    //generating key for dict
                    string keygen = "";
                    for (int j = 0; j < 4; j++)
                    {
                        int rand = random.Next(0, 26);
                        char c = 'A';
                        for (int k = 0; k < rand; k++)
                        {
                            c++;
                        }
                        keygen += c;
                    }
                    //adding persons to dict
                    try
                    {
                        dictionary.Add(keygen, new Person(random));
                    }
                    catch
                    {
                        success = false;
                    }
                } while (!success);
            }
            Stop = DateTime.Now;
            int genTimeD = Stop.Millisecond - Init.Millisecond;

            //printing random 1000 persons
            Init = DateTime.Now;
            for (int i = 0; i < size*0.1; i++)
            {
                int rand = random.Next(0, size);
                Console.WriteLine(dictionary.ElementAt(rand).Value.ToString());
                /*
                if (rand <= dictionary.Count)
                {
                    Console.WriteLine(dictionary.ElementAt(rand));
                }
                */
            }
            Stop = DateTime.Now;
            int priTimeD = Stop.Millisecond - Init.Millisecond;
            
            //printing elapsed times
            Console.WriteLine("List:");
            Console.WriteLine("Time to generate persons: " + genTimeL);
            Console.WriteLine("Time to print persons: " + priTimeL);
            
            //printing elapsed times
            Console.WriteLine("Dict:");
            Console.WriteLine("Time to generate persons: " + genTimeD);
            Console.WriteLine("Time to print persons: " + priTimeD);

            /*
            List:
            Time to generate persons: 24
            Time to print persons: 107
            Dict:
            Time to generate persons: 40
            Time to print persons: 85
            */
        }
    }
}