using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_03
{
    class L09_03_Main
    {
        static void Main(string[] args)
        {
            //collection
            //List<Card> cardSet = new List<Card>();
            Dictionary<int, Card> cardSet = new Dictionary<int, Card>();

            //card generation
            int cardID = 1;
            for (int i = 1; i<=4;i++)
            {
                for (int j = 1; j<=13;j++)
                {
                    cardSet.Add(cardID,new Card(i, j));
                    cardID++;
                }
            }

            //card listing
            foreach (KeyValuePair<int,Card> kvp in cardSet)
            {
                Console.WriteLine("{0} card is {1}", kvp.Key, kvp.Value.ToString());
            }
        }
    }
}
