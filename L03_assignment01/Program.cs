/*Hannu Oksman
Tehtävänäsi on ohjelmoida kiukaan toiminta.Kiuas pitää pystyä 
laittamaan päälle ja pois, sekä sen lämpötilaa että sen antamaa 
kosteutta pitää pystyä säätämään(arvoja ei ole rajattu).

UML
Suunnittele Kiuas-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.

Ohjelmointi
Toteuta Kiuas-luokan ohjelmointi sekä pääohjelma, jolla luot olion 
Kiuas-luokasta.Säädä kiuas-oliota erilaisilla arvoilla, jätä 
Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta kiuas-olion 
käyttäminen jää näkyville.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            //new instance
            Kiuas uusiKiuas = new Kiuas();

            //menu printing
            int exit = 0;
            Console.WriteLine("Kiuas Control System");
            while (exit != 1)
            {
                Console.WriteLine("\nKiuas menu");
                Console.WriteLine("1) System information.");
                Console.WriteLine("2) Power switch.");
                Console.WriteLine("3) Set humidity.");
                Console.WriteLine("4) Set temperature.");
                Console.WriteLine("5) Exit");
                Console.WriteLine("\nInsert selection: ");

                //menu selection
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine(uusiKiuas.KiuasInfo);
                        break;
                    case 2:
                        if (uusiKiuas.PowerStatus == false)
                        {
                            Console.Write("Turn power on? y/n: ");
                            if (Console.ReadLine() == "y")
                            {
                                uusiKiuas.PowerStatus = true;
                                Console.WriteLine("Power: " + uusiKiuas.PowerStatus);    
                            }
                        }
                        else
                        {
                            Console.Write("Power: " + uusiKiuas.PowerStatus + ". Turn power off? y/n: ");
                            if (Console.ReadLine() == "y")
                            {
                                uusiKiuas.PowerStatus = false;
                                Console.WriteLine("Power: " + uusiKiuas.PowerStatus);
                            }                                
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Current humidity: " + uusiKiuas.CurrentHumidity + " Desired humidity: " + uusiKiuas.SetHumidity);
                            Console.Write("Set new desired humidity? (value or c for cancel) ");
                            string answer = Console.ReadLine();
                            if (answer != "c")
                            {
                                uusiKiuas.SetHumidity = int.Parse(answer);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Current temperature: " + uusiKiuas.CurrentTemperature + " desired temperature: " + uusiKiuas.SetTemperature);
                            Console.Write("Set new desired temperature? (value or c for cancel) ");
                            string answer = Console.ReadLine();
                            if (answer != "c")
                            {
                                uusiKiuas.SetTemperature = int.Parse(answer);
                            }
                            break;
                        }
                    case 5:
                        exit = 1;
                        break;
                }
            }
            
             
            /*
            //current temp
            //uusiKiuas.currentTemperature = 50;

            //power on
            Console.WriteLine("Virta päälle? [1=on,0=off] :");
            uusiKiuas.PowerStatus = int.Parse(Console.ReadLine());
            Console.WriteLine("Heating on: " + uusiKiuas.Power(uusiKiuas.PowerStatus));

            //set desired temp
            Console.WriteLine("Set desired temperature:");
            uusiKiuas.setTemperature = int.Parse(Console.ReadLine());
            //uusiKiuas.SetTemperature(uusiKiuas.currentTemperature, uusiKiuas.setTemperature, uusiKiuas.PowerStatus);
            */


        }

    }
}
