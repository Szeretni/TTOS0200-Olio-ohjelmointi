using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_assignment07
{
    class ClassSongs
    {
        //read-only
        public DateTime Duration
        {
            get
            {
                return duration;
            }
        }
        public string Name { get; set; }

        //adds duration
        public void DurationMethod(int minutes, int seconds)
        {
            duration = duration.AddMinutes(minutes);
            duration = duration.AddSeconds(seconds);
        }

        private DateTime duration = new DateTime(2018, 1, 1, 0, 0, 0);
    }
}
