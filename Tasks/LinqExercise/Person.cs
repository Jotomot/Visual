using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    internal class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
