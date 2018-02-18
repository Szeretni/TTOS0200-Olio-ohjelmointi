using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L11_assignment_02
{
    class MailBook
    {
        //constructors
        public MailBook()
        {
            try
            {
                //reading data from file
                string file = "tutut.csv";
                string[] allLines = File.ReadAllLines(file);
                foreach (string s in allLines)
                {
                    string[] split = s.Split(';');
                    friendList.Add(new Friend(split[0], split[1]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //properties
        public List<Friend> Friends { get { return friendList; } }

        //collections
        private List<Friend> friendList = new List<Friend>();

        //methods

    }
}
