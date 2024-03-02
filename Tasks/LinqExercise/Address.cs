using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    internal class Address
    {
        public string City { get; set; }
        public int personID { get; set; }

        public Address(string city, int personID)
        {
            City = city;
            this.personID = personID;
        }
    }
}
