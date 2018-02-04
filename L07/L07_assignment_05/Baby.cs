using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_05
{
    class Baby : Human
    {
        public Baby(int Age)
        {
            this.Age = Age;
        }
        public override int Age { get; set; }
        public override void Move()
        {
            Console.WriteLine("I'm crawling.");
        }
        private string Diaper { get; set; }
    }
}
