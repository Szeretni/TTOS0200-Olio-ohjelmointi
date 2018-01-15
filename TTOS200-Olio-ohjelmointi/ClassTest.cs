using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTOS200_Olio_ohjelmointi
{
    class ClassTest
    {
        //private vain luokka itse voi lukea

        //kukaan ulkopuolinen ei voi lukea
        private readonly int speed = 10;
        public string Color { get; set; }
        private string model;

        public int Speed { get; set; }

        public void Accelerate()
        {
            Speed += 5;
        }

        private string[] strings = new string[100];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < 100)
                {
                    return strings[i];
                }
                else
                {
                    return "out of bounds";
                }
            }
            set
            {
                if (i >= 0 && i < 100)
                {
                    strings[i] = value;
                }
            }
        }

        public void Brake()
        {
            Speed -= 5;
            if (Speed < 0) Speed = 0;
        }
        public string Model
        {
            get { return model; }
            set
            {
                //readonly voi käyttää kuitenkin luokkatiedostossa
                if (value != "toyota" && value != "nissan" && speed < 10)
                {
                    model = "there is no others than toyota and nissan";
                }
                else
                {
                    model = value;
                }
            }
        }

        public ClassTest ()
        {
            //konstruktori alustaa alkuarvolla
            model = "nissan";
        }

        public ClassTest(string model)
        {
            //argumentin pistää alustuksessa 
            //tässä voisi käyttää model, mutta Model
            //on laitettu validaatioita, joten
            //validointia pitäisi itsekin käyttää
            this.Model = model;
        }
        public ClassTest(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        //destructor
        ~ClassTest()
        {
            Console.WriteLine("ClassTest destructor");
        }
    }
}
