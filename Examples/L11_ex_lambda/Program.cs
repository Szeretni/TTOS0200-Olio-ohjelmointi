using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_ex_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nimet = new List<string>() { "Arska", "Kalle", "Cecilia", "Jack" };
            string foo = nimet.FirstOrDefault(x => x.StartsWith("Ja"));
            Console.WriteLine(foo); //this prints Jack
        }
    }
}
