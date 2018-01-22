using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCats(99);
            Console.WriteLine("CatCount: " + Cat.CatCount());
        }

        static void CreateCats(int num)
        {
            int i;
            for (i = 0; i < num; i++)
            {
                Cat cat = new Cat();
            }
        }
    }
}
