using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_assignment_02
{
    class PaidWithCard : ITransaction
    {
        public float GetAmount()
        {
            Console.WriteLine("Total money to our bankaccount " + Money);
            return Money;
        }

        public string ShowTransaction(float Money)
        {
            Billnumber++;
            int second = Billnumber + 1;
            string card = billnumber.ToString() + "-" + second.ToString();
            Console.WriteLine("Transaction to bank: charge from card {0} date: {1} amount: {2}", card, dateTime, Money);
            this.Money = Money;
            return "";
        }

        public float Money
        {
            get
            {
                return money;
            }
            set
            {
                money += value;
            }
        }
        public int Billnumber
        {
            get
            {
                return billnumber;
            }
            set
            {
                billnumber = value;
            }
        }

        public DateTime _DateTime
        {
            get
            {
                return dateTime;
            }
            set
            {
                dateTime = dateTime.Date;
            }
        }

        //properties
        private float money = 0;
        private int billnumber = 0;
        private DateTime dateTime = DateTime.Now;
    }
}
