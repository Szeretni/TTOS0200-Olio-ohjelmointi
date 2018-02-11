using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace L09_assignment_06
{
    class L09_05_Main
    {
        static void Main(string[] args)
        {
            //bin exists, below is not needed
            /*
            Team kalpa = new Team("Kalpa");

            //serialization
            //System.IO.StreamWriter teamFile = new System.IO.StreamWriter("team.txt");
            Stream writeStream = new FileStream("Team.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, kalpa);
            writeStream.Close();
            */

            //deserialization
            IFormatter formatter = new BinaryFormatter();
            Stream readStream = new FileStream("Team.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Team readTeam = (Team)formatter.Deserialize(readStream);
            
            //print
            readTeam.PrintTeam();
        }
    }
}
