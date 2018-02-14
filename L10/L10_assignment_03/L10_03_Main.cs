/*
Tee ohjelma, joka lukee yksinkertaisesta tekstitiedosto nimet.txt henkilöitten nimiä ja kertoo montako nimeä löytyy 
ja montako kertaa kukin nimi esiintyy. Kopioi (tai luo itse vastaava tiedosto) D:\Temp -kansioon ja ohjelmoi koodisi
tarkistamaan onko em.hakemistossa tiedostoa. Käytä File.Exist-metodia.	Huomioi myös muut mahdolliset poikkeukset, 
joita tiedoston käsittely voi aiheuttaa.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //streams

namespace L10_assignment_02
{
    class L10_02_Main
    {
        static void Test()
        {
            try
            {
                //collection
                //List<string> list = new List<string>();

                //file handling
                string myfile = @"D:\nimet.txt";
                //tarkistaa onko olemassa
                if (File.Exists(myfile))
                {
                    //collect names
                    string[] namesstra = File.ReadAllLines(myfile);
                    //from [] to List
                    List<string> nameslist = namesstra.ToList();
                    //count distinct elements
                    IEnumerable<string> namesinum = nameslist.Distinct();
                    Console.WriteLine("Found {0} rows and {1} names.", nameslist.Count(), namesinum.Count());

                    //dict key is distinct, value occurances
                    Dictionary<string, int> namesDict = new Dictionary<string, int>();
                    foreach (string s in namesinum)
                    {
                        namesDict.Add(s, 0);
                    }

                    //update dict values to match occurances
                    foreach (string s in nameslist)
                    {
                        if (namesDict.ContainsKey(s))
                        {
                            namesDict[s]++;
                        }
                    }

                    //from dict to string list
                    List<string> list = new List<string>();
                    foreach (KeyValuePair<string,int> kvp in namesDict)
                    {
                        string temp = "Name " + kvp.Key + " appears " + kvp.Value + " times.";
                        list.Add(temp);
                    }

                    //sorting list
                    list.Sort();

                    //printing
                    foreach (string s in list)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine("Tiedostoa {0} ei löydy.", myfile);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}