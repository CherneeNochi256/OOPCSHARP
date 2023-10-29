public class Polynomial
{
    private double a;
    private double b;
    private double c;

    public Polynomial(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Evaluate(double x)
    {
        return a * Math.Pow(x, 2) + b * x + c;
    }

    public Polynomial Add(Polynomial other)
    {
        double newA = a + other.a;
        double newB = b + other.b;
        double newC = c + other.c;
        return new Polynomial(newA, newB, newC);
    }

    public Polynomial Subtract(Polynomial other)
    {
        double newA = a - other.a;
        double newB = b - other.b;
        double newC = c - other.c;
        return new Polynomial(newA, newB, newC);
    }

    public Polynomial Multiply(Polynomial other)
    {
        double newA = a * other.a;
        double newB = b * other.b;
        double newC = c * other.c;
        return new Polynomial(newA, newB, newC);
    }

    public void Display()
    {
        Console.WriteLine($"The polynomial is: {a}x^2 + {b}x + {c}");
    }
}