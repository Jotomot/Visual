using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    internal class Grades
    {
        Dictionary<string, List<int>> studentsGrades = new Dictionary<string, List<int>>()
        {
            {"Jerry", new List<int>() {} },
            {"Amy", new List<int>() {} },
            {"John", new List<int>() {} }
        };

        public void AddGrade(string studentName, int grade)
        {
            if (studentsGrades.ContainsKey(studentName))
            {
                studentsGrades[studentName].Add(grade);
            }
            else { Console.WriteLine("Podany student nie istnieje"); }
        
            
        }

        public void RemoveGrade(string studentName, int grade)
        {
            studentsGrades[studentName].Remove(grade);
        }

        public double CalculateAverageGrade(string studentName)
        {
            return studentsGrades[studentName].Average();
        }

        public void getListOfStudents()
        {
            foreach (var item in studentsGrades)
            {
                Console.WriteLine(item.Key);
            }
        }

        public void getStudentsGrades(string studentName)
        {
            if (studentsGrades.TryGetValue(studentName, out var student))
            {
                foreach (var item in student)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void getStudentsBestGrade(string studentName)
        {
            Console.WriteLine($"Najwyższa ocena studenta {studentName} to: " + studentsGrades[studentName].Max(grade => grade));
            
        }

       
    }
}
