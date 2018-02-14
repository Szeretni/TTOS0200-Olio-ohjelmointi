using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_assignment_05
{
    [Serializable]
    class TV_Program
    {
        //constructor
        public TV_Program(string ShowName, string Channel,string StartTime,string StopTime,string InfoText)
        {
            this.ShowName = ShowName;
            this.Channel = Channel;
            this.StartTime = StartTime;
            this.StopTime = StopTime;
            this.InfoText = InfoText;
        }

        //methods
        public void PrintInfo()
        {
            Console.WriteLine("Name {0} Channel {1} StartTime {2} StopTime {3} InfoText {4}", ShowName, Channel, StartTime, StopTime, InfoText);
        }

        //properties
        private string ShowName { get; set; }
        private string Channel { get; set; }
        private string StartTime { get; set; }
        private string StopTime { get; set; }
        private string InfoText { get; set; }
    }
}
