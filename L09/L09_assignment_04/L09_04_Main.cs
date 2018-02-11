using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_assignment_03
{
    class L09_03_Main
    {
        static void ShuffleCards(ref Dictionary<int, Card> cardSet)
        {
            //cuts each element to temp dict in random order
            //when cardSet is empty
            //copy temp to cardSet
            //cardSet is now shuffled
            Dictionary<int, Card> temp = new Dictionary<int, Card>();
            Random random = new Random();
            int keyi = 1;
            do
            {
                int randInt = random.Next(1, 53);
                if (cardSet.ContainsKey(randInt))
                {
                    temp.Add(keyi,new Card(cardSet[randInt].Country, cardSet[randInt].Rank));
                    cardSet.Remove(randInt);
                    keyi++;
                }
            } while (temp.Count != 52);
            cardSet = temp;
        }

        static void Main(string[] args)
        {
            //collection
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

            //shuffle cards
            ShuffleCards(ref cardSet);

            //card listing
            foreach (KeyValuePair<int,Card> kvp in cardSet)
            {
                Console.WriteLine("{0} card is {1}", kvp.Key, kvp.Value.ToString());
            }           
        }
    }
}
