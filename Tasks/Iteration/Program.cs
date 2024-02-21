
namespace Iteration;

class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę całkowitą");
        int number = 0;
        int highestNumber = number;
        int sum = 0;

        do
        {   
            number = int.Parse(Console.ReadLine());
            sum = sum + number;
            if (highestNumber < number)
            {
                highestNumber = number;
            }
        } while (number != 0);

        Console.WriteLine("Suma wszystkich podanych liczb to " + sum);
        Console.WriteLine($"Największa podana liczba to {highestNumber}");
    }

}