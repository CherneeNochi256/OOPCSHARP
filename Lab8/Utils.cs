namespace Lab8;

public static class Utils
{
    public static double AverageGrade(this Student student)
    {
        return student.Average();
    }

    public static bool ContainsGrade(this Student student, int grade)
    {
        return student.Contains(grade);
    }
}