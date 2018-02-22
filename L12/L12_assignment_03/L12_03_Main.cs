///@author Hannu Oksman
///@version 2018-02-19
///<summary>
///Toteuta sovellus MyFishApp, jossa voit hallita kalastukseen liittyviä tietoja. Ohjelman pitää pystyä 
///käsittelemään:kalastajan perustiedot (nimi, puhelinnumero), saadun kalan perustiedot (laji, pituus ja paino), 
///sekä kalapaikan perustiedot (nimi ja paikka). Suunnittele tarvittava luokkarakenne, ja piirrä siitä UML-kaavio. 
///Toteuta pääohjelma MyFishApp, jossa käyttäjä voi lisätä kalastajia ja heidän saamiansa kaloja. Tee toiminto jolla 
///voi tulostaa kalarekisterin sisältö eli kaikkien kalastajien saamat kaikki kalat.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_03
{
    class L12_03_Main
    {
        static void Main(string[] args)
        {
            //init collections
            Collections Registry = new Collections();

            //creating fisher
            Fisher.CreateFisher("Kirsi Kernel", "020-12345678", Registry);

            //creating 1st event as per assignment
            string fisher = "Kirsi Kernel";
            Location.CreateLocation("The Lake of Jyvaskyla", "Jyvaskyla", Registry);
            string location = "The Lake of Jyvaskyla";
            Fish f = Fish.CreateFish("pike", 120, 4.5,Registry);
            try
            {
                FishingEvent.CreateFishingEvent(Registry.Fisherlist.FirstOrDefault(x => x.Name == fisher), f, Registry.Locationlist.FirstOrDefault(x => x.Place == location), Registry);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //creating 2nd event as per assignment
            fisher = "Kirsi Kernel";
            Location.CreateLocation("River Teno", "The Northern edge of Finland", Registry);
            location = "River Teno";
            f = Fish.CreateFish("salmon", 190, 13.2,Registry);
            try
            {
                FishingEvent.CreateFishingEvent(Registry.Fisherlist.FirstOrDefault(x => x.Name == fisher), f, Registry.Locationlist.FirstOrDefault(x => x.Place == location), Registry);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //printing fishing events per fisher
            List<string> fisherNames = new List<string>();
            Console.WriteLine("\nAll fish in the register:");

            foreach (FishingEvent fe in Registry.FishingEventDict.Values)
            {
                //prints only once fisher's name
                if (!fisherNames.Contains(fe.fisher.Name))
                {
                    fisherNames.Add(fe.fisher.Name);
                    Console.WriteLine("\nFisherman {0} has got following fish:\n", fe.fisher.Name);
                }
                //then lists fishs she has fished
                if (fisherNames.Contains(fe.fisher.Name))
                {
                    Console.WriteLine(" - specie: {0} {1} cm {2} kg", fe.fish.Specie, fe.fish.Lenght, fe.fish.Weight);
                    Console.WriteLine(" - place: {0}", fe.location.Place);
                    Console.WriteLine(" - location {0}\n", fe.location.LocationS);
                }
            }

            //printing fish info sorted by weight desc
            //fishing events to sortable list
            List<FishingEvent> feList = new List<FishingEvent>();
            foreach (FishingEvent fe in Registry.FishingEventDict.Values)
            {
                feList.Add(fe);
            }
            //sorting list
            feList.Sort((x, y) => y.fish.Weight.CompareTo(x.fish.Weight));
            //printing sorted list
            Console.WriteLine("Sorted register\n\n***All fish in the Fish-register");
            foreach (FishingEvent fe in feList)
            {
                Console.WriteLine();
                fe.PrintFishingEventInfo();
            }
            Console.WriteLine();
        }
    }
}
//prints
/*
A new fisherman added to Fish-register
- Fisherman: Kirsi Kernel Phone: 020-12345678

Fisher : Kirsi Kernel got a new fish
 - specie : pike 120 cm 4,5 kg
 - place : The Lake of Jyvaskyla
 - location : Jyvaskyla

Fisher : Kirsi Kernel got a new fish
 - specie : salmon 190 cm 13,2 kg
 - place : River Teno
 - location : The Northern edge of Finland

All fish in the register:

Fisherman Kirsi Kernel has got following fish:

 - specie: pike 120 cm 4,5 kg
 - place: The Lake of Jyvaskyla
 - location Jyvaskyla

 - specie: salmon 190 cm 13,2 kg
 - place: River Teno
 - location The Northern edge of Finland

Sorted register

*** All fish in the Fish-register

 - salmon 190 cm 13,2 kg
 - place: River Teno
 - location: The Northern edge of Finland
 - Fisherman: Kirsi Kernel

 - pike 120 cm 4,5 kg
 - place: The Lake of Jyvaskyla
 - location: Jyvaskyla
 - Fisherman: Kirsi Kernel
 */