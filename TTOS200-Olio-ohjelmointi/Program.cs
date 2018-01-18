using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* VANILLA
namespace TTOS200_Olio_ohjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/
/*
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
*/

/*
namespace TTOS200_Olio_ohjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTest test = new ClassTest("opel", "green");
            test.Color = "brown";
            test.Model = "mercedes";
            Console.WriteLine(test.Model);

            test[0] = "Hello";
            test[101] = "Last string";
            Console.WriteLine(test[101]);
        }
    }
}
*/

    namespace TTOS200_Olio_ohjelmointi
{
    class Program
    {
        //stringbuilder testing
        static void Main(string[] args)
        {
            StringBuilder str1 = new StringBuilder();
            str1.Append(new char[] { 'D' });
            Console.WriteLine(str1);
            Console.WriteLine(str1.Length);
            string str2 = "asdfasdf";
            Console.WriteLine("{0} chars: {1}", str1.Length, str1.ToString());
            string str3 = str1.ToString();
            if (str1.ToString() == str2) Console.WriteLine("Match");
            else Console.WriteLine("Epic fail");
            if (str3 == str2) Console.WriteLine("Match");
            else Console.WriteLine("Epic fail");
        }           
    }
}