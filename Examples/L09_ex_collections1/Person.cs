﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_ex_collections1
{
    class Person : IComparable
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }

        public int CompareTo(object obj)
        {
            Person compareTo = (Person)obj;
            int lastnames = Lastname.CompareTo(((Person)obj).Lastname);
            if (lastnames == 0) return Firstname.CompareTo(((Person)obj).Firstname);
            return lastnames;
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;
        }
    }
}
