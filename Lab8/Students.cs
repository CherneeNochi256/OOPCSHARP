using System.Collections;

namespace Lab8;

public class Students : IEnumerable<Student>
{
    private readonly List<Student> studentList;

    public Students(List<Student> students)
    {
        studentList = students;
    }

    public IEnumerator<Student> GetEnumerator()
    {
        return studentList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Student> OrderByLastName()
    {
        return studentList.OrderBy(s => s.LastName);
    }

    public IEnumerable<Student> OrderByRating()
    {
        return studentList.OrderBy(s => s.AverageGrade());
    }

    public IEnumerable<Student> OrderByGrade(int grade)
    {
        return studentList.Where(s => s.ContainsGrade(grade)).OrderBy(s => s.LastName);
    }
}