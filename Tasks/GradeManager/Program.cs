namespace GradeManager;

class Program
{
    public static void Main(string[] args)
    {
        Grades gradeManager = new Grades();

        gradeManager.getListOfStudents();

        Console.WriteLine("Dodaję oceny 1,2,3,4,5 uczniowi Jerry");
        gradeManager.AddGrade("Jerry", 1);
        gradeManager.AddGrade("Jerry", 2);
        gradeManager.AddGrade("Jerry", 3);
        gradeManager.AddGrade("Jerrys", 4);
        gradeManager.AddGrade("Jerry", 5);

        Console.WriteLine("Wyświetlam średnią ocenę Jerry'ego: " + gradeManager.CalculateAverageGrade("Jerry"));

        Console.WriteLine("Usuwam oceny 4 i 5 Jerry'ego ");
        gradeManager.RemoveGrade("Jerry", 4);
        gradeManager.RemoveGrade("Jerry", 5);
        Console.WriteLine("Wyświetlam średnią ocenę Jerry'ego: " + gradeManager.CalculateAverageGrade("Jerry"));

        Console.WriteLine("Wyświetlam oceny Jerrego");
        gradeManager.getStudentsGrades("Jerry");

        gradeManager.getStudentsBestGrade("Jerry");

    }
}