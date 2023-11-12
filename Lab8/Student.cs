using System.Collections;

namespace Lab8;

public class Student : IComparable<Student>, IEnumerable<int>
{
    private List<int> grades;

    public Student(string lastName, List<int> grades)
    {
        LastName = lastName;
        this.grades = grades;
    }

    public List<int> Grades
    {
        get => grades;
        set => grades = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName { get; set; }

    public int CompareTo(Student other)
    {
        return string.Compare(LastName, other.LastName, StringComparison.Ordinal);
    }

    public IEnumerator<int> GetEnumerator()
    {
        return grades.GetEnumerator();
    }


    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}