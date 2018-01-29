using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_ex_aggregation
{
    class L07_ex_main
    {
        static void Main(string[] args)
        {
           
            Luser luser = new Luser("Arska");
            User user1 = new User(luser);
            User user2 = new User(new Luser("Yuri"));
            user1 = null;
            user2 = null;
            GC.Collect(); //  User is destructed,  User is destructed, User Yuri is destructed
            Console.ReadLine();
            // Luser Arska is destructed
        }
    }
}
