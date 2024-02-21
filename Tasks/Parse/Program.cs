using Microsoft.VisualBasic;
using System.Reflection;

namespace Parse;

class MyClass
{
    static void Main(string[] args)
    {
        int yearOfBirth = 0;
        int monthOfBirth = 0;
        int dayOfBirth;

        Console.WriteLine("Podaj Rok urodzenia");

        yearOfBirth = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj miesiąc urodzenia");

        monthOfBirth = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj dzień urodzenia");

        dayOfBirth = int.Parse(Console.ReadLine());

        int yourAge = (DateTime.Now.Year - yearOfBirth);

        Console.WriteLine("Twój wiek to " + yourAge);




        Console.WriteLine("Liczba dni przeżytych w pierwszym roku życia " + numberOfDaysInFirstYearOfLife(yearOfBirth, monthOfBirth, dayOfBirth));
        Console.WriteLine("Liczba dni przeżytych w ciągu bieżącego roku " + numberOfDaysInLastYearOfLife());
        Console.Write("Przeżyłeś ");
        if (yearOfBirth != DateTime.Now.Year)
        {
            Console.Write(numberOfDaysInParticularYear(yearOfBirth, monthOfBirth, dayOfBirth) +
                numberOfDaysInFirstYearOfLife(yearOfBirth, monthOfBirth, dayOfBirth) +
                numberOfDaysInLastYearOfLife() + " Dni Gratulacje");
        }else
        {
            Console.Write(numberOfDaysInParticularYear(yearOfBirth, monthOfBirth, dayOfBirth) +
                numberOfDaysInLastYearOfLife() + " Dni Gratulacje");
        }
    }

    public static int numberOfDaysInFirstYearOfLife(int yearOfBirth, int MonthOfBirth, int DayOfBirth) 
    {   
        if(yearOfBirth == DateTime.Now.Year)
        {
            return numberOfDaysInLastYearOfLife();
        }

        int sumOfDays = 0;

        while (MonthOfBirth < 13)
        {
            sumOfDays += DateTime.DaysInMonth(yearOfBirth, MonthOfBirth);
            MonthOfBirth++;
        }
        return sumOfDays - DayOfBirth;
    
    }

    public static int numberOfDaysInLastYearOfLife()
    {

        int sumOfDays = 0;

        for (int i = 1; i < (DateTime.Now.Month + 1); i++)
        {
            sumOfDays += DateTime.DaysInMonth(DateTime.Now.Year, i);
            
        }
        return sumOfDays - (DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month) - DateTime.Now.Day);

    }

    public static int numberOfDaysInParticularYear(int yearOfBirth, int MonthOfBirth, int DayOfBirth)
    {
        int numberOfDaysInAllYears = 0;

        while ((yearOfBirth + 1) < DateTime.Now.Year)
        {

            for (int i = 0; i < 12; i++)
            {
                numberOfDaysInAllYears += DateTime.DaysInMonth(yearOfBirth, i + 1);
            }
            yearOfBirth++;
        }

        return numberOfDaysInAllYears;

    }
}