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
        public void FindFriend()
        {
            Console.Write("\nWrite your friend's name or beginning of the name:");
            string searchFor = Console.ReadLine();

            //syntax tip https://stackoverflow.com/questions/415866/lambda-expressions-how-to-search-inside-an-object
            var finding = this.Friends.Where(x => x.Name.StartsWith(searchFor));
            var formatting = string.Join("\n", finding.Select(x => x.Name + " " + x.Email));
            Console.WriteLine(formatting);
        }

        public void AddFriend()
        {
            //adding to mailbook
            Console.Write("Type friend's name:");
            string name = Console.ReadLine();
            Console.Write("Type friend's email:");
            string email = Console.ReadLine();
            this.Friends.Add(new Friend(name, email));

            //saving new friend to hd
            try
            {
                string file = "tutut.csv";
                if (System.IO.File.Exists(file))
                {
                    using (System.IO.StreamWriter sw = System.IO.File.AppendText(file))
                    {
                        sw.WriteLine(name + ";" + email);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
