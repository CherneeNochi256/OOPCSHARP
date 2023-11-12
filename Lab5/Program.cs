// 100 best students 
// 10 faculties
// need to create groups, each group contains 2 persons from each faculty
// so i need to create 5 groups

using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

// 1. Создайте перечисление для факультетов
enum Faculty
{
    Faculty1,
    Faculty2,
    Faculty3,
    Faculty4
}

// 2. Определите класс Student
class Student
{
    public string Name { get; set; }
    public Faculty Faculty { get; set; }
}

class Program
{
    static void Main()
    {
        // Получите список студентов, упорядоченный по фамилиям
        List<Student> students = GetStudents();

        // Введите количество групп и студентов в каждой группе
        int groupCount = GetGroupCount();
        int studentsPerGroup = GetStudentsPerGroup(students.Count, groupCount);

        // Распределение студентов по группам
        List<List<Student>> groups = DistributeStudents(students, groupCount, studentsPerGroup);

        // Вывод результатов
        PrintGroups(groups);
    }

    static List<Student> GetStudents()
    {
        // Вернуть список студентов, упорядоченных по фамилиям
        // Здесь можно использовать свою собственную логику для получения списка студентов
        return new List<Student>
        {
            new Student { Name = "Иванов", Faculty = Faculty.Faculty1 },
            new Student { Name = "Петров", Faculty = Faculty.Faculty2 },
            new Student { Name = "Сидоров", Faculty = Faculty.Faculty3 },
            new Student { Name = "Смирнов", Faculty = Faculty.Faculty4 },
            // ...
        }.OrderBy(s => s.Name).ToList();
    }

    static int GetGroupCount()
    {
        Console.Write("Введите количество групп: ");
        return int.Parse(Console.ReadLine());
    }

    static int GetStudentsPerGroup(int studentCount, int groupCount)
    {
        // Рассчитать количество студентов в каждой группе
        int studentsPerGroup = studentCount / groupCount;

        // Если количество студентов не делится равномерно на группы, добавить одного студента в каждую группу
        if (studentCount % groupCount != 0)
        {
            studentsPerGroup++;
        }

        return studentsPerGroup;
    }

    static List<List<Student>> DistributeStudents(List<Student> students, int groupCount, int studentsPerGroup)
    {
        // Создать список групп с пустыми списками студентов
        List<List<Student>> groups = new List<List<Student>>();
        for (int i = 0; i < groupCount; i++)
        {
            groups.Add(new List<Student>());
        }

        // Распределить студентов по группам
        int currentGroupIndex = 0;
        foreach (var student in students)
        {
            groups[currentGroupIndex].Add(student);

            // Перейти к следующей группе, если текущая группа заполнилась
            if (groups[currentGroupIndex].Count == studentsPerGroup)
            {
                currentGroupIndex++;
            }
        }

        return groups;
    }

    static void PrintGroups(List<List<Student>> groups)
    {
        for (int i = 0; i < groups.Count; i++)
        {
            Console.WriteLine($"Группа {i + 1}:");
            foreach (var student in groups[i])
            {
                Console.WriteLine($"{student.Name} - {student.Faculty}");
            }
            Console.WriteLine();
        }
    }
}
