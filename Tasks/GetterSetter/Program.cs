namespace GetterSetter;

class MyClass
{
    public static void Main(string[] args)
    {
        Person John = new Person("Jerry",DateTime.Now);
        John.DateOfBirth = new DateTime(1991, 12, 12);
        Console.WriteLine(John.DateOfBirth);
    }    
}