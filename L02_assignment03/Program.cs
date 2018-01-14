/*Hannu Oksman
Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle 
hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin 
tyylipiste.

Esimerkkitoiminta:
    Give points: 18 [Enter]
    Give points: 15 [Enter]
    Give points: 20 [Enter]
    Give points: 19 [Enter]
    Give points: 17 [Enter]
    Total points are 54
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbrRatings = 5;
            int[] pointarray = new int[nbrRatings];
            for (int i = 0; i < nbrRatings; i++)
            {
                Console.Write("Give points: ");
                pointarray[i] = System.Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < nbrRatings; i++)
            {
                //nbrRatings-1 in order to avoid overflow
                for (int j = 0; j < (nbrRatings-1); j++)
                {
                    if (pointarray[j]<pointarray[j+1])
                    {
                        int temp = pointarray[j];
                        pointarray[j] = pointarray[j+1];
                        pointarray[j+1] = temp;
                    }
                }
            }
            int result = 0;
            //discard 1st and last
            for (int i = 1; i < (nbrRatings-1); i++)
            {
                result += pointarray[i];
            }
            Console.WriteLine("Total points are " + result + ".");
        }
    }
}