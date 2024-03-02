namespace LinqExercise;

class MyClass
{
    public static void Main(string[] args)

    {

        List<Address> listOfAdresses = new List<Address>() {
            new Address("Lublin", 1) ,
            new Address("Warszawa", 1),
            new Address("Maciejowice", 2) };

        List<Person> listOfPersons = new List<Person>()
        {
            new Person("Jerry",1),
            new Person("Bob", 2),
            new Person("Bezdomny Harry",3) };

        var interJoin = listOfPersons.Join(listOfAdresses,
            p => p.Id,
            a => a.personID,
            (person,adress) => new {person.Name,adress.City});

        var joined = listOfPersons.LeftJoin(listOfAdresses);
        


        foreach (var ad in interJoin)
        {
            Console.WriteLine($"Imię: {ad.Name} miasto {ad.City}");
            
        }
        Console.WriteLine("--------");

        foreach (var ad in joined)
        {
            Console.WriteLine($"Imię: {ad.Name} miasto {ad.City}");
        }
    }
}