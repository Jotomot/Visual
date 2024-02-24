namespace TelephoneDirectory;


class MyClass
{
    
    public static void Main(string[] args) 
    {
        Console.WriteLine("Dodaje kontakty Jerry 322444555, John 999777666, Amy 222333444");
        Logic logic = new Logic();
        logic.addContact("Jerry", 322444555);
        logic.addContact("John", 999777666);
        logic.addContact("Amy", 222333444);

        Console.WriteLine("Wyświetlam kontakty");
        logic.showContacts();

        Console.WriteLine("Szukam kontaktu o nazwie Jerry");
        logic.FindContactByName("Jerry");

        Console.WriteLine("Szukam kontaktu o numerze telefonu 222333444");
        logic.FindContactByNumber(222333444);
        Console.WriteLine("Szukam kontaktu o numerze telefonu 222333000");
        logic.FindContactByNumber(222333000);

    }
    
}