using Inheritance;

namespace Inheritance;

class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.Model = "audi";

        car1.Start();
        car1.Stop();

        Motorcycle motor = new Motorcycle();
        motor.Model = "Kawasaki";
        motor.Start();


    }
}