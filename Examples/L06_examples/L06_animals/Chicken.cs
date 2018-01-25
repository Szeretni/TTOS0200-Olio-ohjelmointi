using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_animals
{
    class Chicken : Animal
    {
        public override int Legs
        {
            get
            {
                return 2;
            }
        }

        //overriden-ketjun katkaisu, nyt uusi metodi, ei peritty
        //public new void Talk()
        public override void Talk()
        {
            Console.WriteLine("CotCot!");
        }

        public void chickenSpecial()
        {
            Console.WriteLine("Chicken Special!");
        }
    }
}
