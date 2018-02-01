using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_ex_interface_example
{
    interface IConnectionStatusListener
    {
        void OnConnectionStarted();
        void OnConnectionSuccess();
        void OnConnectionFailure();
    }
    class InternetConnection
    {
        public void Connect(IConnectionStatusListener listener)
        {
            Console.WriteLine("Connecting to Internet");

            if (listener != null) listener.OnConnectionStarted();
            System.Threading.Thread.Sleep(4000);

            Random rand = new Random();
            if (rand.Next(0,10)<8)
            {
                if (listener != null) listener.OnConnectionSuccess();
            }
            else
            {
                if (listener != null) listener.OnConnectionFailure();
            }

            Console.WriteLine("Connection attempt completed.");
        }
    }
}
