using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_assignment_02
{
    class Friend
    {
        public Friend(string Name,string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }

        public string Name { get; set; }
        public string Email { get; set; }
    }
}
