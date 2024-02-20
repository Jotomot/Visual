// See https://aka.ms/new-console-template for more information
using Coding.Exercise;
using System;

namespace Coding.Exercise
{
    public class GradeCalculator
    {
        public static string CalculateGrade(double percentage) {
            if (percentage > 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else return "F";
        }
    } }

namespace IfCalc
{ }

    class IfProgram {
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wynik procentowy, a ja podam ocenę");
        int percentage = int.Parse(Console.ReadLine());

        Console.WriteLine(GradeCalculator.CalculateGrade(percentage));

    }
} 
