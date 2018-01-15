/*Hannu Oksman
Tee ohjelma, joka tulostaa seuraavanlaisen kuvion.Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.

Give a number: 7 [Enter]
        *
       ***
      *****
     *******
    *********
        *
        *
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_assignment05
{
    class Program
    {
        static void Main(string[] args)
        {
            int trunkHeight = 2;
            Console.Write("Give a number: ");
            int height = System.Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                int j;
                //printing twigs
                if (i < (height - trunkHeight))
                {
                    j = i;
                }
                //printing trunk
                else
                {
                    j = 0;
                }
                printSpace(height, j, trunkHeight);
                printStar(j);
                Console.WriteLine();
            }
        }

        static void printSpace(int height, int i, int trunkHeight)
        {
            //-1 (to manage i=0) and -trunkheight to remove unnecessary whitespace reserved for trunk's "twigs"
            int whitespace = height - i - trunkHeight - 1;
            for (int j = 0; j < whitespace; j++)
            {
                Console.Write(" ");
            }
        }

        static void printStar(int i)
        {
            //stars to provide symmetry
            int stars = 2 * i + 1;
            for (int j = 0; j < stars;j++)
            {
                Console.Write("*");
            }
        }       
    }
}
