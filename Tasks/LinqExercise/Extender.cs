using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace LinqExercise
{
    internal static class Extender
    {
        public static IEnumerable<Joined> LeftJoin(this List<Person> listOfPersons, List<Address> listOfAdresses)
        {
            
            var joined = listOfPersons.GroupJoin(listOfAdresses, p => p.Id, a => a.personID, (person, address) => new { Person = person, Address = address })
    .SelectMany(person => person.Address.DefaultIfEmpty(), (person, adres) => new Joined { Name = person.Person.Name, City = adres?.City });
            return joined;
        }
        
    }
}
