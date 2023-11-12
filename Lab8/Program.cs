using Lab8;

public class Program
{
    public static void Main()
    {
        var students = new List<Student>
        {
            new("Smith", new List<int> { 85, 90, 92 }),
            new("Johnson", new List<int> { 92, 88, 95 }),
            new("Williams", new List<int> { 78, 82, 80 }),
            new("Jones", new List<int> { 89, 91, 87 })
        };

        var studentCollection = new Students(students);

        Console.WriteLine("Ordered by Last Name:");
        foreach (var student in studentCollection.OrderByLastName())
            Console.WriteLine($"Last Name: {student.LastName}, Grades: {string.Join(", ", student)}");

        Console.WriteLine();

        Console.WriteLine("Ordered by Rating:");
        foreach (var student in studentCollection.OrderByRating())
            Console.WriteLine($"Last Name: {student.LastName}, Average Grade: {student.AverageGrade()}");

        Console.WriteLine();

        var gradeToSearch = 90;
        Console.WriteLine($"Students with grade {gradeToSearch}:");
        foreach (var student in studentCollection.OrderByGrade(gradeToSearch))
            Console.WriteLine($"Last Name: {student.LastName}, Grades: {string.Join(", ", student)}");
    }
}