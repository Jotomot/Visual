namespace NumberGenerator;

class MyClass
{
    public static IEnumerable<int> GenerateEvenNumbers()
    {
        for (int i = 0; i < 10; i++) 
        {
            if ( i % 2 == 0)
            yield return i;
        }
    }
    public static void Main(string[] args)
    {
        var Numbers = GenerateEvenNumbers();
        foreach (int i in Numbers)
        {
            Console.WriteLine("Polecenie wygenerowania kolejnej liczby parzystej ");
            Console.WriteLine(i);
        }
    
    }
    
}