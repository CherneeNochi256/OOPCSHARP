namespace Lab3;

public class Program

{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n-------------------Lab3.3.1-----------------------\n");
        Testing.TestPointD();
        Console.WriteLine("\n-------------------Lab3.3.2-----------------------\n");
        TestLineD();
    }

    private static void TestLineD()
    {
        // Создаем две точки
        PointD point1 = new PointD(0, 0);
        PointD point2 = new PointD(1, 1);

// Создаем две линии
        LineD line1 = new LineD(); // Линия, проходящая через точки (0,0) и (1,1)
        LineD line2 = new LineD(point1, point2); // Линия, проходящая через заданные точки

// Проверяем, являются ли линии параллельными
        bool isParallel = line1.IsParallel(line2);
        if (isParallel)
        {
            Console.WriteLine("Линии параллельны");
        }
        else
        {
            Console.WriteLine("Линии не параллельны");
        }

// Находим точку пересечения двух линий
        PointD? intersectionPoint = line1.FindIntersection(line2);
        if (intersectionPoint != null)
        {
            Console.WriteLine("Точка пересечения: " + intersectionPoint.ToString());
        }
        else
        {
            Console.WriteLine("Линии не пересекаются.");
        }
    }
}