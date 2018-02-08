using System;
using System.Collections.Generic;
using System.IO; //streams
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class NamesToFile
    {
        static void Test()
        {
            try
            {
                string line;
                string myfile = @"D:\l2912\testi.txt"; // @ kertoo, että \ ei ole ohjausmerkki, ilman D:\\l29...
                //luodaan tiedosto
                using (StreamWriter sw = new StreamWriter(myfile))
                {
                    //kysytään käyttäjältä nimet ja kirjoitetaan nimet tiedostoon
                    do
                    {
                        Console.WriteLine("Anna henkilön nimi (tyhjä lopettaa)");
                        line = Console.ReadLine();
                        if (line.Length > 0)
                        {
                            sw.WriteLine(line);
                        }
                    } while (line.Length > 0);
                    sw.Close();
                }
                //avataan tiedosto lukua varten
                if (File.Exists(myfile))
                {
                    //näytetään nimet
                    string txt = File.ReadAllText(myfile);
                    Console.WriteLine("Tiedostossa {0} on nimet: {1}", myfile, txt);
                }
                else
                {
                    Console.WriteLine("Tiedostoa {0} ei löydy.",myfile);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
