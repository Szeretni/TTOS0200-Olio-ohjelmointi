/*
Tee ohjelma, jossa voidaan käsitellä TV-ohjelmia. 
TV-ohjelman tietoina tulee käsitellä: ohjelman nimi, kanava (jolta ohjelma tulee), alku- ja loppuaika sekä pienimuotoinen infoteksti ohjelmasta. 
Luo pääohjelmassa muutamia TV-ohjelmaolioita (tiedot voit alustaa suoraan koodista, ei tarvitse kysyä käyttäjältä) ja tallenna ne levylle. 
Mieti käytätkö jotain tietorakennetta apunasi. 
Toteuta ohjelmaan myös tiedostonlukeminen ja tulosta TV-oliot näkyville.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace L10_assignment_05
{
    class L10_05_Main
    {
        static void Main(string[] args)
        {
            //collection
            List<TV_Program> list = new List<TV_Program>();
            /*IN COMMENTS TO VALIDATE DESERIALIZATION
            //creating tv-programs
            try
            {
                list.Add(new TV_Program("Real Madrid vs. PSG", "Viasat", "20180214T21:00:00Z", "20180215T00:30:00Z", "Uefa Champions League"));
                list.Add(new TV_Program("Porto vs. Liverpool", "Viasat", "20180214T21:30:00Z", "20180215T00:00:00Z", "Uefa Champions League"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            //serialization
            try
            {
                //code from L09_06_Main.cs
                Stream writeStream = new FileStream("TVObjects.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                foreach (TV_Program t in list)
                {
                    formatter.Serialize(writeStream, t);
                }
                writeStream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
            //deserialization
            IFormatter formatter = new BinaryFormatter();
            Stream readStream = new FileStream("TVObjects.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            while (true)
            {
                try
                {
                    list.Add((TV_Program)formatter.Deserialize(readStream));
                }
                catch (Exception ex)
                {
                    //works
                    //Console.WriteLine(ex.Message);
                    break;
                }
            }
            
            //printing objects
            try
            {
                foreach (TV_Program t in list)
                {
                    t.PrintInfo();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*deserailization works, print below:
            Name Real Madrid vs. PSG Channel Viasat StartTime 20180214T21:00:00Z StopTime 20180215T00:30:00Z InfoText Uefa Champions League
            Name Porto vs. Liverpool Channel Viasat StartTime 20180214T21:30:00Z StopTime 20180215T00:00:00Z InfoText Uefa Champions League
            */
        }
    }
}