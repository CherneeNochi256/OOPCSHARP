namespace Lab3;

public class LineD
{
    private PointD point1;
    private PointD point2;
    private double a, b, c;

    public LineD()
    {
        // Уравнение линии, проходящей через точки (0,0) и (1,1)
        point1 = new PointD(0, 0);
        point2 = new PointD(1, 1);
        CalculateEquation();
    }

    public LineD(PointD point1, PointD point2)
    {
        // Уравнение линии, проходящей через заданные точки
        this.point1 = point1;
        this.point2 = point2;
        CalculateEquation();
    }

    private void CalculateEquation()
    {
        // Вычисляем коэффициенты a, b, c уравнения прямой вида ax + by + c = 0
        a = point2.Y - point1.Y;
        b = point1.X - point2.X;
        c = point2.X * point1.Y - point1.X * point2.Y;
    }

    public bool IsParallel(LineD otherLine)
    {
        // Проверяем, являются ли две прямые параллельными
        return (a * otherLine.b - b * otherLine.a) == 0;
    }

    public PointD? FindIntersection(LineD otherLine)
    {
        // Находим точку пересечения двух прямых
        double determinant = a * otherLine.b - b * otherLine.a;
        if (determinant == 0)
        {
            // Прямые не пересекаются
            return null;
        }
        else
        {
            double x = (b * otherLine.c - c * otherLine.b) / determinant;
            double y = (c * otherLine.a - a * otherLine.c) / determinant;
            return new PointD(x, y);
        }
    }
}