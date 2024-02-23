using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GetterSetter
{
    internal class Person
    { 
        private string name;
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, DateTime datetime) : this(name)
        {
            DateOfBirth = datetime;
        }
    }
}
