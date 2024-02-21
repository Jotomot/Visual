
using System.Net.NetworkInformation;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ile godzin spedziles na parkingu");
        Console.WriteLine(" Opłata wynosi " + CalculateParkingFee(int.Parse(Console.ReadLine()))); 
      
    }

    public static double CalculateParkingFee(int hours)
    {
        double result = 0;

        switch (hours)
        {
            case 0:
                Console.WriteLine("Podaj wartość minimum 1");
                return 0;
                break;
            case 1:
                result = 5;
                break;
            default:
                result = 5 + ((hours - 1) * 3);
                break;
        }
        return result;
    }

}