/*Hannu Oksman
Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            foreach (int integer in intarray)
            {
                if ((integer % 2) == 0) Console.WriteLine("HEP");
            }
        }
    }
}
