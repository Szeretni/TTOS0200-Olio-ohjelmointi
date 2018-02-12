using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TTOS200_Olio_ohjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "asdfasfdsaf";
            Console.WriteLine(s.GetHashCode());
        }
    }
    /* VANILLA
        class Program
        {
            static void Main(string[] args)
            {
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
                char c = 'A';
                for (int i = 0; i<26;i++)
                {
                    Console.WriteLine(c);
                    c++;
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

                int i = 1;
                int j = ++i;
                Console.WriteLine(i + " " + j);
                int k = 1;
                int l = k++;
                Console.WriteLine(k + " " + l);
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

                var varint = 5;
                Console.WriteLine(varint);
                var varstr = "str";
                Console.WriteLine(varstr);
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
    /*//StringBuilder
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

                Console.WriteLine("\n\nBelow is meaningful print\n\n");
                StringBuilder strbld = new StringBuilder(Int16.MaxValue);
                string _1string = "asfdqerw";
                strbld.Append(_1string);
                strbld.Append(_1string);
                Console.WriteLine(strbld);
                Console.WriteLine("{0} chars: {1}", strbld.Length, strbld.ToString());
                string asdf = "asdf";
                string qwer = "qwer";
                asdf += qwer;
                Console.WriteLine(asdf);
            }           
        }
    }
    */
    /*
    //Cultureinfo
    namespace TTOS200_Olio_ohjelmointi
    {
        class Program
        {
            static void Main(string[] args)
            {
                float number = 1050.75F;
                DateTime today = DateTime.Today;

                // Creates a CultureInfo for Finnish in Finland.
                CultureInfo fi = new CultureInfo("fi-FI");
                // Displays i formatted as currency for the Finland.
                Console.WriteLine(number.ToString("c", fi));
                Console.WriteLine(today.ToString("d", fi));

                // Creates a CultureInfo for English in the U.S.
                CultureInfo us = new CultureInfo("en-US");
                // Display i formatted as currency for us.
                Console.WriteLine(number.ToString("c", us));
                Console.WriteLine(today.ToString("d", us));

                // Creates a CultureInfo for Swedish in Sweden.
                CultureInfo se = new CultureInfo("sv-SE");
                // Displays i formatted as currency for Swedish people
                Console.WriteLine(number.ToString("c", se));
                Console.WriteLine(today.ToString("d", se));
            }
        }
    }*/
}