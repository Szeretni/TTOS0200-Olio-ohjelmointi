/*Hannu Oksman
Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina 
kysytään käyttäjältä.

Esimerkkitoiminta:
    Give seconds: 3661 [Enter]
    Seconds can be shown as 1 hour 1 minute and 1 second
*/
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment05
{
    class assignment05
    {
        static void Main(string[] args)
        {
            Console.Write("Give seconds: ");
            double answer = int.Parse(Console.ReadLine());
            DateTime seconds = new DateTime(2018,1,1,0,0,0);
            seconds = seconds.AddSeconds(answer);
            Console.WriteLine("Seconds can be shown as " + seconds.Hour + " hour " + seconds.Minute + " minute and " + seconds.Second + " second.");
        }
    }
}
