using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    internal class Contact
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public Contact(string name, int phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }


    }
}
