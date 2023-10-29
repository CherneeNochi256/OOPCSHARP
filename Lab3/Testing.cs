namespace Lab3;

public class Testing
{
    public static void TestPointD()
    {
        // Создаем несколько экземпляров PointD для проверки
        PointD p1 = new PointD(3, 4);
        PointD p2 = new PointD(5, Math.PI / 4);
        PointD p3 = new PointD(10);
        PointD p4 = new PointD(p3);
        PointD p5 = new PointD(12.3);


        // Проверяем методы и свойства структуры PointD
        Console.WriteLine("p1: " + p1);
        Console.WriteLine("p2: " + p2);
        Console.WriteLine("p3: " + p3);
        Console.WriteLine("p4: " + p4);
        Console.WriteLine("p5: " + p5);

        // Проверяем методы перемещения
        p1.MoveX(2);
        p2.MoveY(-1);
        p3.MoveR(5);
        p3.MoveFI(Math.PI / 2);

        Console.WriteLine("p1 после перемещения по X: " + p1);
        Console.WriteLine("p2 после перемещения по Y: " + p2);
        Console.WriteLine("p3 после перемещения по R и FI: " + p3);

        // Проверяем операторы сравнения
        Console.WriteLine("p1 == p2: " + (p1 == p2));
        Console.WriteLine("p1 != p2: " + (p1 != p2));
        Console.WriteLine("p2 == p3: " + (p2 == p3));
        Console.WriteLine("p2 != p3: " + (p2 != p3));
    }
}