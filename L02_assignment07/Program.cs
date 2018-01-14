/*Hannu Oksman
Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon.Tulosta lopuksi
lajitellun taulukon sisältö.

Esimerkkitoiminta:
    Numbers in an array 1: 10,20,30,40,50
    Numbers in an array 2: 5,15,25,35,45
    Numbers in the combined array: 5,10,15,20,25,30,35,40,45,50
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_assignment07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 10, 20, 30, 40, 50 };
            int[] secondArray = { 5, 15, 25, 35, 45 };
            int firstNumbers = 0, secondNumbers =0;
            foreach (int i in firstArray)
            {
                firstNumbers++;
            }
            foreach (int i in secondArray)
            {
                secondNumbers++;
            }
            int numberOfNumbers = firstNumbers + secondNumbers;
            int[] thirddArray = new int[numberOfNumbers];
            for (int i = 0; i < firstNumbers; i++)
            {
                thirddArray[i] = firstArray[i];
            }
            for (int i = 0; i < secondNumbers; i++)
            {
                thirddArray[i + firstNumbers] = secondArray[i];
            }
            for (int i = 0; i < numberOfNumbers; i++)
            {
                for (int j = 0; j < numberOfNumbers - 1; j++)
                {
                    int temp = thirddArray[j];
                    if (thirddArray[j] > thirddArray[j + 1])
                    {
                        thirddArray[j] = thirddArray[j + 1];
                        thirddArray[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < numberOfNumbers; i++)
            {
                if (i == numberOfNumbers - 1)
                {
                    Console.WriteLine(thirddArray[i]);
                }
                else
                {
                    Console.Write(thirddArray[i] + ",");
                }
            }
        }
    }
}