/*Hannu Oksman
Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä 
järjestyksessä.

Esimerkkitoiminta:

Give a number: 1 [Enter]
    Give a number: 2 [Enter]
    Give a number: 3 [Enter]
    Give a number: 4 [Enter]
    Give a number: 5 [Enter]
    Number are 5,4,3,2,1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 5;
            int[] intArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Give a number: ");
                intArray[i] = System.Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize-1; j++)
                {
                    int temp = intArray[j];
                    if (intArray[j] < intArray[j+1])
                    {
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arraySize; i++)
            {
                if (i == arraySize-1)
                {
                    Console.WriteLine(intArray[i]);
                }
                else
                {
                    Console.Write(intArray[i] + ",");
                }
            }
        }
    }
}
