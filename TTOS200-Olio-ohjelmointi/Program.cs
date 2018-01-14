using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASCII-print
namespace TTOS200_Olio_ohjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = '0';
            character -= '0';
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(i + ": " + character);
                character++;
            }
        }
    }
}
