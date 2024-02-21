
using System.ComponentModel.Design;

namespace BMICalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            double bodyWeight;
            double height;

            Console.WriteLine("Podaj masę ciała w kilogramach");
            bodyWeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokość w metrach, jako separatora użyj przecinka");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Twoje BMI to " + BMICalculate(bodyWeight,height));
            


        }


        static string BMICalculate(double bodyWeight, double height)   
        {
        double result = bodyWeight / (height * height);
            Console.WriteLine("Twój wskaźnik BMI wynosi " + result);

            if ((result < 18.5))
            {
                return " Niedowaga";
            }
            else if((result >= 18.5) && (result <= 24.9))
            {
                return " Waga normalna";
            }
            else if ((result >= 25) && (result <= 29.9))
            {
                return " Nadwaga";
            } else if ((result >= 30) && (result <= 34.9))
            {
                return " Otyłość";
            }
            else return "Otyłość olbrzymia";
            

        }


    }
}