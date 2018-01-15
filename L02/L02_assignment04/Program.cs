/*Hannu Oksman
Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). Tulosta arvosanajakauma käyttäen 
tähtimerkkejä seuraavasti:

Arvosanajakauma:
0:
1:****
2:**
3:******
4:*****
5:**

Esimerkkitoiminta:
    Give grade: 5 [Enter]
    Give grade: 5 [Enter]
    Give grade: 4 [Enter]
    Give grade: 3 [Enter]
    Give grade: 2 [Enter]
    Give grade: 1 [Enter]
    Give grade: 0 [Enter]
    Give grade: 0 [Enter]
    Grades:
    0:**
    1:*
    2:*
    3:*
    4:*
    5:**
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbrGrades = 8;
            int[] grades = new int[nbrGrades];
            for (int i = 0; i < nbrGrades; i++)
            {
                Console.Write("Give grade: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0: grades[0]++; break;
                    case 1: grades[1]++; break;
                    case 2: grades[2]++; break;
                    case 3: grades[3]++; break;
                    case 4: grades[4]++; break;
                    case 5: grades[5]++; break;
                }
            }
            for (int i = 0; i < 6;i++)
            {
                Console.Write(i + ":");
                starPrint(grades[i]);
                Console.WriteLine();
            }
        }

        static void starPrint(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
        }
    }
}