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

            //creating 1 event
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

            //creating 1 event
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
            
            /*
            foreach (Fisher f in Registry.Fisherlist)
            {
                f.PrintFisher();
            }
            */
            /*
            Fisher fisher = new Fisher("Kirsi Kernel","020-12345678");
            Fish fish = new Fish("pike", 120, 4.5);
            Location location = new Location("The Lake of Jyvaskyla", "Jyvaskyla");
            FishingEvent fishingevet = new FishingEvent()
            */
        }
    }
}
